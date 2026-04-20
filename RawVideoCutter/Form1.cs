using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawVideoCutter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ── Win32 for borderless drag ─────────────────────────────────────────
        [DllImport("user32.dll")] private static extern int  SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")] private static extern bool ReleaseCapture();

        // Drop shadow on borderless form
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                var cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        // Subtle 1px border painted around the window edge
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using var pen = new Pen(Color.FromArgb(65, 65, 65), 1);
            e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
        }

        // ── Custom title bar ──────────────────────────────────────────────────
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1 /*WM_NCLBUTTONDOWN*/, 0x2 /*HTCAPTION*/, 0);
            }
        }

        private void btnWinMin_Click(object sender, EventArgs e)   => WindowState = FormWindowState.Minimized;
        private void btnWinClose_Click(object sender, EventArgs e) => Close();
        private void btnWinMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState    = FormWindowState.Normal;
                btnWinMax.Text = "□";
            }
            else
            {
                WindowState    = FormWindowState.Maximized;
                btnWinMax.Text = "❐";
            }
        }

        // ── Core fields ───────────────────────────────────────────────────────
        private Stopwatch _exportStopwatch;
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        private string _inputFilePath;
        private List<string> _folderVideoPaths = new List<string>();
        private string _exportFolderPath;

        // ── Seek / markers ────────────────────────────────────────────────────
        private bool _draggingSeek;
        private long _startMs = -1;
        private long _endMs   = -1;

        // ── Waveform ──────────────────────────────────────────────────────────
        private Bitmap _waveformBitmap;
        private CancellationTokenSource _waveformCts;

        // ─────────────────────────────────────────────────────────────────────
        private void Form1_Load(object sender, EventArgs e)
        {
            Core.Initialize(Application.StartupPath);

            _libVLC      = new LibVLC("--no-video-title-show");
            _mediaPlayer = new MediaPlayer(_libVLC);
            videoView.MediaPlayer = _mediaPlayer;

            _mediaPlayer.EndReached += (s, _) =>
            {
                Task.Run(() => _mediaPlayer.Stop());
                this.BeginInvoke(new Action(() =>
                {
                    btnPlayPause.Text = "▶  Play";
                    panelSeek.Invalidate();
                }));
            };

            var settings = Properties.Settings.Default;
            if (!string.IsNullOrEmpty(settings.SourceFolderPath) && Directory.Exists(settings.SourceFolderPath))
            {
                txtFolderPath.Text = settings.SourceFolderPath;
                LoadFolderVideos(settings.SourceFolderPath);
            }
            if (!string.IsNullOrEmpty(settings.ExportFolderPath) && Directory.Exists(settings.ExportFolderPath))
            {
                _exportFolderPath    = settings.ExportFolderPath;
                txtExportFolder.Text = _exportFolderPath;
            }
        }

        // ── Keyboard shortcuts ────────────────────────────────────────────────
        // Space = play/pause  |  [ = set start  |  ] = set end
        // Left/Right = frame step (paused) or ±5 s (playing)
        // Shift+Left/Right = ±30 s
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Don't steal keys when a text box has focus
            if (ActiveControl is TextBox) return base.ProcessCmdKey(ref msg, keyData);

            switch (keyData)
            {
                case Keys.Space:
                    btnPlayPause_Click(null, EventArgs.Empty);
                    return true;

                case Keys.OemOpenBrackets:   // [
                    btnSetStart_Click(null, EventArgs.Empty);
                    return true;

                case Keys.OemCloseBrackets:  // ]
                    btnSetEnd_Click(null, EventArgs.Empty);
                    return true;

                case Keys.Left:
                    if (_mediaPlayer.IsPlaying)
                        SeekToMs(_mediaPlayer.Time - 5000);
                    else
                        SeekToMs(_mediaPlayer.Time - 40);   // ~1 frame back
                    return true;

                case Keys.Right:
                    if (_mediaPlayer.IsPlaying)
                        SeekToMs(_mediaPlayer.Time + 5000);
                    else
                    {
                        _mediaPlayer.NextFrame();           // exact next frame when paused
                        panelSeek.Invalidate();
                    }
                    return true;

                case Keys.Left | Keys.Shift:
                    SeekToMs(_mediaPlayer.Time - 30000);
                    return true;

                case Keys.Right | Keys.Shift:
                    SeekToMs(_mediaPlayer.Time + 30000);
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // ── Load video ────────────────────────────────────────────────────────
        private async void btnOpenVideo_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Filter = "All Video Files|*.ts;*.mp4;*.mkv;*.avi;*.mov;*.wmv;*.flv;*.webm;*.m4v;*.mpeg;*.mpg;*.3gp;*.ogv|All files (*.*)|*.*"
            };
            if (ofd.ShowDialog() != DialogResult.OK) return;
            await LoadVideoAsync(ofd.FileName);
        }

        private async Task LoadVideoAsync(string path)
        {
            _inputFilePath = path;

            // Reset markers
            _startMs = -1;
            _endMs   = -1;
            panelSeek.Invalidate();

            // Kick off waveform generation in background
            _ = GenerateWaveformAsync(path);

            var media = new Media(_libVLC, path, FromType.FromPath);

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
                            Text     = $"Audio Track {track.Id}: {track.Description ?? ""}",
                            Tag      = track.Id,
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

        // ── Waveform generation ───────────────────────────────────────────────
        private async Task GenerateWaveformAsync(string videoPath)
        {
            // Cancel any previous in-flight generation
            _waveformCts?.Cancel();
            _waveformCts = new CancellationTokenSource();
            var token = _waveformCts.Token;

            _waveformBitmap?.Dispose();
            _waveformBitmap = null;
            panelSeek.Invalidate();

            int pw = panelSeek.Width;
            int ph = panelSeek.Height;
            string tmp = Path.Combine(Path.GetTempPath(), "rawvc_waveform.png");

            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName  = "ffmpeg.exe",
                    Arguments = $"-i \"{videoPath}\" -filter_complex " +
                                $"\"showwavespic=s={pw}x{ph}:colors=0x2d8fb0|0x2d8fb0:draw=full:scale=sqrt:bgcolor=0x1e1e1e00\" " +
                                $"-frames:v 1 -y \"{tmp}\"",
                    UseShellExecute      = false,
                    RedirectStandardError = true,
                    CreateNoWindow       = true
                };

                var proc = new Process { StartInfo = psi };
                token.Register(() => { try { proc.Kill(); } catch { } });

                proc.Start();
                proc.BeginErrorReadLine();
                await Task.Run(() => proc.WaitForExit());

                if (token.IsCancellationRequested || !File.Exists(tmp)) return;

                var bmp = new Bitmap(tmp);
                if (token.IsCancellationRequested) { bmp.Dispose(); return; }

                _waveformBitmap = bmp;
                panelSeek.BeginInvoke(new Action(() => panelSeek.Invalidate()));
            }
            catch (OperationCanceledException) { }
            catch { /* waveform is optional — never crash for it */ }
            finally
            {
                try { File.Delete(tmp); } catch { }
            }
        }

        // ── Folder browser ────────────────────────────────────────────────────
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
            var ext = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                ".ts", ".mp4", ".mkv", ".avi", ".mov", ".wmv",
                ".flv", ".webm", ".m4v", ".mpeg", ".mpg", ".3gp", ".ogv"
            };

            _folderVideoPaths = Directory.GetFiles(folderPath)
                .Where(f => ext.Contains(Path.GetExtension(f)))
                .OrderBy(f => f)
                .ToList();

            lstVideos.Items.Clear();
            foreach (var f in _folderVideoPaths)
                lstVideos.Items.Add(Path.GetFileName(f));

            labelVideoCount.Text = $"{_folderVideoPaths.Count} video(s) — double-click to open";
        }

        private async void lstVideos_DoubleClick(object sender, EventArgs e)
        {
            if (lstVideos.SelectedIndex < 0) return;
            await LoadVideoAsync(_folderVideoPaths[lstVideos.SelectedIndex]);
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
                labelVideoCount.Text = $"{_folderVideoPaths.Count} video(s) — double-click to open";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not delete file:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Audio ─────────────────────────────────────────────────────────────
        private void AudioChannel_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            if (cb.Checked)
                _mediaPlayer.SetAudioTrack((int)cb.Tag);
        }

        // ── Playback ──────────────────────────────────────────────────────────
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (_mediaPlayer.IsPlaying)
            {
                _mediaPlayer.Pause();
                btnPlayPause.Text = "▶  Play";
            }
            else
            {
                _mediaPlayer.Play();
                btnPlayPause.Text = "⏸  Pause";
            }
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            _mediaPlayer.Volume = trackBarVolume.Value;
            labelVolVal.Text    = trackBarVolume.Value.ToString();
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

        // ── Seek bar ──────────────────────────────────────────────────────────
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
            SeekToMs((long)(ratio * _mediaPlayer.Length));
        }

        private void SeekToMs(long ms)
        {
            if (_mediaPlayer.Length <= 0) return;
            long target = Math.Max(0, Math.Min(_mediaPlayer.Length, ms));
            label3.Text = TimeSpan.FromMilliseconds(target).ToString(@"hh\:mm\:ss");

            if (_mediaPlayer.State == VLCState.Stopped || _mediaPlayer.State == VLCState.Ended)
            {
                void OnPlaying(object s2, EventArgs e2)
                {
                    _mediaPlayer.Playing -= OnPlaying;
                    _mediaPlayer.Time     = target;
                    _mediaPlayer.SetPause(true);
                }
                _mediaPlayer.Playing += OnPlaying;
                _mediaPlayer.Play();
            }
            else
            {
                _mediaPlayer.Time = target;
            }

            panelSeek.Invalidate();
        }

        // ── Seek bar painting ─────────────────────────────────────────────────
        private void panelSeek_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int w    = panelSeek.Width;
            int h    = panelSeek.Height;
            int midY = h / 2;
            const int barH = 4;
            int barY = midY - barH / 2;

            // Waveform background
            if (_waveformBitmap != null)
            {
                var cm = new ColorMatrix { Matrix33 = 0.55f };
                using var attr = new ImageAttributes();
                attr.SetColorMatrix(cm);
                g.DrawImage(_waveformBitmap,
                    new Rectangle(0, 0, w, h),
                    0, 0, _waveformBitmap.Width, _waveformBitmap.Height,
                    GraphicsUnit.Pixel, attr);
            }

            // Base track
            using var bgBrush = new SolidBrush(Color.FromArgb(_waveformBitmap != null ? 60 : 80, 80, 80));
            g.FillRectangle(bgBrush, 0, barY, w, barH);

            if (_mediaPlayer?.Length > 0)
            {
                long total = _mediaPlayer.Length;

                // In/out shaded region
                if (_startMs >= 0 && _endMs >= 0 && _endMs > _startMs)
                {
                    int x1 = (int)((double)_startMs / total * w);
                    int x2 = (int)((double)_endMs   / total * w);
                    using var regionBrush = new SolidBrush(Color.FromArgb(50, 40, 200, 100));
                    g.FillRectangle(regionBrush, x1, 0, x2 - x1, h);
                }

                // Playhead progress
                double ratio = Math.Max(0, Math.Min(1, (double)_mediaPlayer.Time / total));
                int fillW = (int)(ratio * w);
                using var fgBrush = new SolidBrush(Color.FromArgb(0, 120, 215));
                g.FillRectangle(fgBrush, 0, barY, fillW, barH);

                // Thumb
                const int r = 7;
                using var thumbBrush = new SolidBrush(Color.White);
                g.FillEllipse(thumbBrush, fillW - r, midY - r, r * 2, r * 2);

                // In/out marker triangles
                DrawMarker(g, _startMs, total, w, h, Color.FromArgb(50, 210, 90));   // green = start
                DrawMarker(g, _endMs,   total, w, h, Color.FromArgb(220, 80,  80));  // red   = end
            }
        }

        private static void DrawMarker(Graphics g, long ms, long totalMs, int pw, int ph, Color color)
        {
            if (ms < 0 || totalMs <= 0) return;
            int x    = (int)((double)ms / totalMs * pw);
            const int sz = 6;

            // Triangle pointing down from top
            var tri = new Point[]
            {
                new Point(x,      sz + 1),   // tip
                new Point(x - sz, 0),
                new Point(x + sz, 0)
            };
            using var brush = new SolidBrush(color);
            g.FillPolygon(brush, tri);

            // Vertical line from tip to bottom
            using var pen = new Pen(color, 1.5f);
            g.DrawLine(pen, x, sz + 1, x, ph);
        }

        // ── In/Out points ─────────────────────────────────────────────────────
        private void btnSetStart_Click(object sender, EventArgs e)
        {
            _startMs           = _mediaPlayer.Time;
            txtStartTime.Text  = TimeSpan.FromMilliseconds(_startMs).ToString(@"hh\:mm\:ss");
            panelSeek.Invalidate();
        }

        private void btnSetEnd_Click(object sender, EventArgs e)
        {
            _endMs           = _mediaPlayer.Time;
            txtEndTime.Text  = TimeSpan.FromMilliseconds(_endMs).ToString(@"hh\:mm\:ss");
            panelSeek.Invalidate();
        }

        // ── Fullscreen ────────────────────────────────────────────────────────
        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            if (_mediaPlayer == null) return;

            var fsForm = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                WindowState     = FormWindowState.Maximized,
                BackColor       = Color.Black,
                KeyPreview      = true
            };

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
                videoView.Dock     = origDock;
                videoView.Size     = origSize;
                videoView.Location = origLoc;
                origParent.Controls.Add(videoView);
            };

            fsForm.Show(this);
        }

        // ── Export folder ─────────────────────────────────────────────────────
        private void btnSelectExportFolder_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog { Description = "Select export destination folder" };
            if (!string.IsNullOrEmpty(_exportFolderPath))
                fbd.SelectedPath = _exportFolderPath;

            if (fbd.ShowDialog() != DialogResult.OK) return;
            _exportFolderPath    = fbd.SelectedPath;
            txtExportFolder.Text = _exportFolderPath;

            Properties.Settings.Default.ExportFolderPath = _exportFolderPath;
            Properties.Settings.Default.Save();
        }

        // ── Export ────────────────────────────────────────────────────────────
        private async void btnExport_Click(object sender, EventArgs e)
        {
            string outputFile;
            string extension;

            if (!string.IsNullOrEmpty(_exportFolderPath) && !string.IsNullOrEmpty(_inputFilePath))
            {
                extension  = ".mp4";
                outputFile = Path.Combine(_exportFolderPath,
                    Path.GetFileNameWithoutExtension(_inputFilePath) + extension);
            }
            else
            {
                using var sfd = new SaveFileDialog
                {
                    Filter      = "MP4 File (*.mp4)|*.mp4|Transport Stream (*.ts)|*.ts|MKV File (*.mkv)|*.mkv|AVI File (*.avi)|*.avi",
                    FilterIndex = 1,
                    FileName    = "cut.mp4"
                };
                if (sfd.ShowDialog() != DialogResult.OK) return;
                outputFile = sfd.FileName;
                extension  = Path.GetExtension(outputFile).ToLower();
            }

            if (!TimeSpan.TryParse(txtStartTime.Text, out var start) ||
                !TimeSpan.TryParse(txtEndTime.Text,   out var end)   ||
                string.IsNullOrEmpty(_inputFilePath))
            {
                MessageBox.Show("Invalid start/end time or no file loaded.");
                return;
            }

            TimeSpan duration    = end - start;
            string codecArgs     = extension == ".mp4" ? "-c copy -movflags +faststart" : "-c copy";
            string arguments     = $"-ss {txtStartTime.Text} -i \"{_inputFilePath}\" " +
                                   $"-t {duration:hh\\:mm\\:ss} -map 0 {codecArgs} -y \"{outputFile}\"";

            Debug.WriteLine("FFMPEG args: " + arguments);

            var psi = new ProcessStartInfo
            {
                FileName              = "ffmpeg.exe",
                Arguments             = arguments,
                UseShellExecute       = false,
                RedirectStandardError = true,
                CreateNoWindow        = true
            };

            progressBarExport.Value  = 0;
            btnExport.Enabled        = false;
            labelRemainingTime.Text  = "";
            _exportStopwatch         = Stopwatch.StartNew();

            var proc = new Process { StartInfo = psi, EnableRaisingEvents = true };

            proc.ErrorDataReceived += (s, ea) =>
            {
                if (string.IsNullOrEmpty(ea.Data)) return;
                if (!ea.Data.Contains("time=")) return;

                int idx = ea.Data.IndexOf("time=") + 5;
                if (idx >= ea.Data.Length) return;

                string timeStr = ea.Data.Substring(idx).Split(' ')[0];
                if (!TimeSpan.TryParse(timeStr, out var cur)) return;

                double pct       = cur.TotalSeconds / duration.TotalSeconds * 100;
                double elapsed   = _exportStopwatch.Elapsed.TotalSeconds;
                double remaining = pct > 0 ? elapsed / pct * (100 - pct) : 0;
                string remStr    = remaining > 0
                    ? $"~{TimeSpan.FromSeconds(remaining):mm\\:ss} remaining" : "";

                progressBarExport.Invoke(new Action(() =>
                {
                    progressBarExport.Value = Math.Min(100, (int)pct);
                    labelRemainingTime.Text = remStr;
                }));
            };

            proc.Start();
            proc.BeginErrorReadLine();
            await Task.Run(() => proc.WaitForExit());

            _exportStopwatch.Stop();
            btnExport.Enabled       = true;
            progressBarExport.Value = 100;
            labelRemainingTime.Text = "Done";

            MessageBox.Show("Export complete!");

            // ── Auto-advance to next video in list ────────────────────────────
            int curIdx = _folderVideoPaths.IndexOf(_inputFilePath);
            if (curIdx >= 0 && curIdx + 1 < _folderVideoPaths.Count)
            {
                int nextIdx = curIdx + 1;
                lstVideos.SelectedIndex = nextIdx;
                await LoadVideoAsync(_folderVideoPaths[nextIdx]);
            }
        }
    }
}
