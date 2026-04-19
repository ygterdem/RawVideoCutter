using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        private List<string> _folderVideoPaths = new List<string>();
        private string _exportFolderPath;

        private void Form1_Load(object sender, EventArgs e)
        {
            Core.Initialize(Application.StartupPath);

            _libVLC = new LibVLC("--no-video-title-show");
            _mediaPlayer = new MediaPlayer(_libVLC);
            videoView.MediaPlayer = _mediaPlayer;

            _mediaPlayer.EndReached += (s, e) =>
            {
                Task.Run(() => _mediaPlayer.Stop());
                this.BeginInvoke(new Action(() =>
                {
                    btnPlayPause.Text = "▶  Play";
                    panelSeek.Invalidate();
                }));
            };

            var s = Properties.Settings.Default;
            if (!string.IsNullOrEmpty(s.SourceFolderPath) && Directory.Exists(s.SourceFolderPath))
            {
                txtFolderPath.Text = s.SourceFolderPath;
                LoadFolderVideos(s.SourceFolderPath);
            }
            if (!string.IsNullOrEmpty(s.ExportFolderPath) && Directory.Exists(s.ExportFolderPath))
            {
                _exportFolderPath = s.ExportFolderPath;
                txtExportFolder.Text = _exportFolderPath;
            }
        }

        private async void btnOpenVideo_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "All Video Files|*.ts;*.mp4;*.mkv;*.avi;*.mov;*.wmv;*.flv;*.webm;*.m4v;*.mpeg;*.mpg;*.3gp;*.ogv|All files (*.*)|*.*"
            };

            if (ofd.ShowDialog() != DialogResult.OK) return;
            await LoadVideoAsync(ofd.FileName);
        }

        private async Task LoadVideoAsync(string path)
        {
            _inputFilePath = path;
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

        private void btnDeleteVideo_Click(object sender, EventArgs e)
        {
            int idx = lstVideos.SelectedIndex;
            if (idx < 0) return;

            string path = _folderVideoPaths[idx];
            string name = Path.GetFileName(path);

            if (MessageBox.Show($"Delete \"{name}\" from disk?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            if (string.Equals(path, _inputFilePath, StringComparison.OrdinalIgnoreCase))
            {
                Task.Run(() => _mediaPlayer.Stop());
                _inputFilePath = null;
            }

            try
            {
                File.Delete(path);
                _folderVideoPaths.RemoveAt(idx);
                lstVideos.Items.RemoveAt(idx);
                labelVideoCount.Text = $"{_folderVideoPaths.Count} video(s) found — double-click to open";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not delete file:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog { Description = "Select folder containing raw videos" };
            if (!string.IsNullOrEmpty(txtFolderPath.Text))
                fbd.SelectedPath = txtFolderPath.Text;

            if (fbd.ShowDialog() != DialogResult.OK) return;

            txtFolderPath.Text = fbd.SelectedPath;
            LoadFolderVideos(fbd.SelectedPath);

            Properties.Settings.Default.SourceFolderPath = fbd.SelectedPath;
            Properties.Settings.Default.Save();
        }

        private void LoadFolderVideos(string folderPath)
        {
            var extensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                ".ts", ".mp4", ".mkv", ".avi", ".mov", ".wmv", ".flv", ".webm", ".m4v", ".mpeg", ".mpg", ".3gp", ".ogv"
            };

            _folderVideoPaths = Directory.GetFiles(folderPath)
                .Where(f => extensions.Contains(Path.GetExtension(f)))
                .OrderBy(f => f)
                .ToList();

            lstVideos.Items.Clear();
            foreach (var f in _folderVideoPaths)
                lstVideos.Items.Add(Path.GetFileName(f));

            labelVideoCount.Text = $"{_folderVideoPaths.Count} video(s) found — double-click to open";
        }

        private async void lstVideos_DoubleClick(object sender, EventArgs e)
        {
            if (lstVideos.SelectedIndex < 0) return;
            await LoadVideoAsync(_folderVideoPaths[lstVideos.SelectedIndex]);
            tabControl.SelectedTab = tabPageCutter;
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
                label2.Text = TimeSpan.FromMilliseconds(_mediaPlayer.Length).ToString(@"hh\:mm\:ss");
                if (!_draggingSeek)
                {
                    label3.Text = TimeSpan.FromMilliseconds(_mediaPlayer.Time).ToString(@"hh\:mm\:ss");
                    panelSeek.Invalidate();
                }
            }
        }

        private bool _draggingSeek;

        private void panelSeek_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _draggingSeek = true;
            SeekToX(e.X);
        }

        private void panelSeek_MouseMove(object sender, MouseEventArgs e)
        {
            if (_draggingSeek && e.Button == MouseButtons.Left)
                SeekToX(e.X);
        }

        private void panelSeek_MouseUp(object sender, MouseEventArgs e)
        {
            _draggingSeek = false;
        }

        private void SeekToX(int x)
        {
            if (_mediaPlayer.Length <= 0) return;

            double ratio = Math.Max(0, Math.Min(1, (double)x / panelSeek.Width));
            long seekTarget = (long)(ratio * _mediaPlayer.Length);
            label3.Text = TimeSpan.FromMilliseconds(seekTarget).ToString(@"hh\:mm\:ss");

            if (_mediaPlayer.State == VLCState.Stopped || _mediaPlayer.State == VLCState.Ended)
            {
                void OnPlaying(object s2, EventArgs e2)
                {
                    _mediaPlayer.Playing -= OnPlaying;
                    _mediaPlayer.Time = seekTarget;
                    _mediaPlayer.SetPause(true);
                }
                _mediaPlayer.Playing += OnPlaying;
                _mediaPlayer.Play();
            }
            else
            {
                _mediaPlayer.Time = seekTarget;
            }

            panelSeek.Invalidate();
        }

        private void panelSeek_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int w = panelSeek.Width;
            int h = panelSeek.Height;
            int midY = h / 2;
            const int barH = 4;
            int barY = midY - barH / 2;

            using var bgBrush = new SolidBrush(Color.FromArgb(80, 80, 80));
            g.FillRectangle(bgBrush, 0, barY, w, barH);

            if (_mediaPlayer?.Length > 0)
            {
                double ratio = Math.Max(0, Math.Min(1, (double)_mediaPlayer.Time / _mediaPlayer.Length));
                int fillW = (int)(ratio * w);

                using var fgBrush = new SolidBrush(Color.FromArgb(0, 120, 215));
                g.FillRectangle(fgBrush, 0, barY, fillW, barH);

                const int r = 7;
                int cx = fillW;
                using var thumbBrush = new SolidBrush(Color.White);
                g.FillEllipse(thumbBrush, cx - r, midY - r, r * 2, r * 2);
            }
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

        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            if (_mediaPlayer == null) return;

            var fsForm = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                BackColor = Color.Black,
                KeyPreview = true
            };

            // Move the existing VideoView (VLC keeps rendering to the same HWND)
            var origParent = videoView.Parent;
            var origDock   = videoView.Dock;
            var origSize   = videoView.Size;
            var origLoc    = videoView.Location;

            origParent.Controls.Remove(videoView);
            videoView.Dock = DockStyle.Fill;
            fsForm.Controls.Add(videoView);

            fsForm.KeyDown += (s, ke) =>
            {
                if (ke.KeyCode == Keys.Escape || ke.KeyCode == Keys.F11)
                    fsForm.Close();
            };

            fsForm.FormClosed += (s, fce) =>
            {
                fsForm.Controls.Remove(videoView);
                videoView.Dock   = origDock;
                videoView.Size   = origSize;
                videoView.Location = origLoc;
                origParent.Controls.Add(videoView);
            };

            fsForm.Show(this);
        }

        private void btnSelectExportFolder_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog { Description = "Select export destination folder" };
            if (!string.IsNullOrEmpty(_exportFolderPath))
                fbd.SelectedPath = _exportFolderPath;

            if (fbd.ShowDialog() != DialogResult.OK) return;
            _exportFolderPath = fbd.SelectedPath;
            txtExportFolder.Text = _exportFolderPath;

            Properties.Settings.Default.ExportFolderPath = _exportFolderPath;
            Properties.Settings.Default.Save();
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            string outputFile;
            string extension;

            if (!string.IsNullOrEmpty(_exportFolderPath) && !string.IsNullOrEmpty(_inputFilePath))
            {
                string baseName = Path.GetFileNameWithoutExtension(_inputFilePath);
                extension = ".mp4";
                outputFile = Path.Combine(_exportFolderPath, baseName + extension);
            }
            else
            {
                using SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "MP4 File (*.mp4)|*.mp4|Transport Stream (*.ts)|*.ts|MKV File (*.mkv)|*.mkv|AVI File (*.avi)|*.avi|MOV File (*.mov)|*.mov|WebM File (*.webm)|*.webm",
                    FilterIndex = 1,
                    FileName = "cut.mp4"
                };
                if (sfd.ShowDialog() != DialogResult.OK) return;
                outputFile = sfd.FileName;
                extension = Path.GetExtension(outputFile).ToLower();
            }
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
                ".mp4" => "-c copy -movflags +faststart",
                _ => "-c copy"
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
            labelRemainingTime.Text = "";
            _exportStopwatch = Stopwatch.StartNew();

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
                            double elapsed = _exportStopwatch.Elapsed.TotalSeconds;
                            double remaining = percent > 0 ? elapsed / percent * (100 - percent) : 0;
                            string remainingStr = remaining > 0
                                ? $"~{TimeSpan.FromSeconds(remaining):mm\\:ss} remaining"
                                : "";
                            progressBarExport.Invoke(new Action(() =>
                            {
                                progressBarExport.Value = Math.Min(100, (int)percent);
                                labelRemainingTime.Text = remainingStr;
                            }));
                        }
                    }
                }
            };

            proc.Start();
            proc.BeginErrorReadLine();

            await Task.Run(() => proc.WaitForExit());

            _exportStopwatch.Stop();
            btnExport.Enabled = true;
            progressBarExport.Value = 100;
            labelRemainingTime.Text = "Done";
            MessageBox.Show("Export complete!");
        }
    }
}