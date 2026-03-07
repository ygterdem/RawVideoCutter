using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace RawVideoCutter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Stopwatch _exportStopwatch;
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        private string _inputFilePath;

        private void Form1_Load(object sender, EventArgs e)
        {
            var options = new[]
            {
                "--no-video-title-show",
                "--video-filter=scale",
                "--scale=0.05"
            };

            Core.Initialize();
            _libVLC = new LibVLC(options);
            _mediaPlayer = new MediaPlayer(_libVLC);
            videoView.MediaPlayer = _mediaPlayer;
        }

        async private void btnOpenVideo_Click(object sender, EventArgs e)
        {
            

            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "All Video Files|*.ts;*.mp4;*.mkv;*.avi;*.mov;*.wmv;*.flv;*.webm;*.m4v;*.mpeg;*.mpg;*.3gp;*.ogv|All files (*.*)|*.*"
            };

            if (ofd.ShowDialog() != DialogResult.OK) return;

            _inputFilePath = ofd.FileName;
            var media = new Media(_libVLC, _inputFilePath, FromType.FromPath);

            media.ParsedChanged += (s, args) =>
            {
                var tracks = media.Tracks.Where(t => t.TrackType == TrackType.Audio).ToList();
                this.Invoke(new Action(() =>
                {
                    panelAudioChannels.Controls.Clear();
                    foreach (var track in tracks)
                    {
                        var cb = new CheckBox
                        {
                            Text = $"Audio Track {track.Id}: {track.Description ?? ""}",
                            Tag = track.Id,
                            AutoSize = true
                        };
                        cb.CheckedChanged += AudioChannel_CheckedChanged;
                        panelAudioChannels.Controls.Add(cb);
                    }
                }));
            };

            await media.Parse(MediaParseOptions.ParseLocal);
            _mediaPlayer.Play(media);
        }

        private void AudioChannel_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            int trackId = (int)cb.Tag;

            if (cb.Checked)
                _mediaPlayer.SetAudioTrack(trackId);
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (_mediaPlayer.IsPlaying)
            {
                _mediaPlayer.Pause();
                btnPlayPause.Text = "Play";
            }
            else
            {
                _mediaPlayer.Play();
                btnPlayPause.Text = "Pause";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_mediaPlayer.Length > 0)
            {
                label1.Text = "00:00:00";
                label2.Text = TimeSpan.FromMilliseconds(_mediaPlayer.Length).ToString(@"hh\:mm\:ss");
                label3.Text = TimeSpan.FromMilliseconds(_mediaPlayer.Time).ToString(@"hh\:mm\:ss");
                trackBarSeek.Maximum = (int)_mediaPlayer.Length;
                trackBarSeek.Value = Math.Min((int)_mediaPlayer.Time, trackBarSeek.Maximum);
            }
        }

        private void trackBarSeek_Scroll(object sender, EventArgs e)
        {
            _mediaPlayer.Time = trackBarSeek.Value;
            label3.Text = trackBarSeek.Value.ToString();
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            _mediaPlayer.Volume = trackBarVolume.Value;
            labelVolVal.Text = trackBarVolume.Value.ToString();
        }

        private void btnSetStart_Click(object sender, EventArgs e)
        {
            txtStartTime.Text = TimeSpan.FromMilliseconds(_mediaPlayer.Time).ToString(@"hh\:mm\:ss");
        }

        private void btnSetEnd_Click(object sender, EventArgs e)
        {
            txtEndTime.Text = TimeSpan.FromMilliseconds(_mediaPlayer.Time).ToString(@"hh\:mm\:ss");
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            using SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "MP4 File (*.mp4)|*.mp4|Transport Stream (*.ts)|*.ts|MKV File (*.mkv)|*.mkv|AVI File (*.avi)|*.avi|MOV File (*.mov)|*.mov|WebM File (*.webm)|*.webm",
                FilterIndex = 1,
                FileName = "cut.mp4"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            string outputFile = sfd.FileName;
            string extension = System.IO.Path.GetExtension(outputFile).ToLower();
            string startTime = txtStartTime.Text;
            string endTime = txtEndTime.Text;

            if (!TimeSpan.TryParse(startTime, out var start) ||
                !TimeSpan.TryParse(endTime, out var end) ||
                string.IsNullOrEmpty(_inputFilePath))
            {
                MessageBox.Show("Invalid start/end time or input file.");
                return;
            }

            TimeSpan duration = end - start;
            string durationStr = duration.ToString(@"hh\:mm\:ss");

            string codecArgs = extension switch
            {
                ".mp4" => "-c:v libx264 -c:a aac -movflags +faststart",
                ".mkv" => "-c:v libx264 -c:a aac",
                ".mov" => "-c:v libx264 -c:a aac",
                ".webm" => "-c:v libvpx-vp9 -c:a libopus",
                ".avi" => "-c:v libx264 -c:a mp3",
                ".ts" => "-c copy",
                _ => "-c:v libx264 -c:a aac"
            };

            string arguments =
                $"-ss {startTime} -i \"{_inputFilePath}\" -t {durationStr} -map 0 {codecArgs} -y \"{outputFile}\"";

            Debug.WriteLine("FFMPEG args: " + arguments);

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "ffmpeg.exe",
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            progressBarExport.Value = 0;
            btnExport.Enabled = false;

            var proc = new Process { StartInfo = psi, EnableRaisingEvents = true };

            proc.ErrorDataReceived += (s, ea) =>
            {
                if (string.IsNullOrEmpty(ea.Data)) return;

                string line = ea.Data;

                if (line.Contains("time="))
                {
                    int idx = line.IndexOf("time=") + 5;
                    if (idx < line.Length)
                    {
                        string timeStr = line.Substring(idx).Split(' ')[0];
                        if (TimeSpan.TryParse(timeStr, out var current))
                        {
                            double percent = current.TotalSeconds / duration.TotalSeconds * 100;
                            progressBarExport.Invoke(new Action(() =>
                            {
                                progressBarExport.Value = Math.Min(100, (int)percent);
                            }));
                        }
                    }
                }
            };

            proc.Start();
            proc.BeginErrorReadLine();

            await Task.Run(() => proc.WaitForExit());

            btnExport.Enabled = true;
            progressBarExport.Value = 100;
            MessageBox.Show("Export complete!");
        }
    }
}