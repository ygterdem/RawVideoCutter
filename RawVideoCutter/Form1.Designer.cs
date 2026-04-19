namespace RawVideoCutter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCutter = new System.Windows.Forms.TabPage();
            this.videoView = new LibVLCSharp.WinForms.VideoView();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.panelSeek = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.labelVolVal = new System.Windows.Forms.Label();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.labelStartHint = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.btnSetStart = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.labelEndHint = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.btnSetEnd = new System.Windows.Forms.Button();
            this.labelExportProgress = new System.Windows.Forms.Label();
            this.labelRemainingTime = new System.Windows.Forms.Label();
            this.btnFullscreen = new System.Windows.Forms.Button();
            this.labelExportFolder = new System.Windows.Forms.Label();
            this.txtExportFolder = new System.Windows.Forms.TextBox();
            this.btnSelectExportFolder = new System.Windows.Forms.Button();
            this.progressBarExport = new System.Windows.Forms.ProgressBar();
            this.labelAudioTracks = new System.Windows.Forms.Label();
            this.panelAudioChannels = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageFolder = new System.Windows.Forms.TabPage();
            this.labelFolder = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.lstVideos = new System.Windows.Forms.ListBox();
            this.btnDeleteVideo = new System.Windows.Forms.Button();
            this.labelVideoCount = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabPageCutter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.tabPageFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageCutter);
            this.tabControl.Controls.Add(this.tabPageFolder);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(946, 650);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageCutter
            // 
            this.tabPageCutter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPageCutter.Controls.Add(this.btnFullscreen);
            this.tabPageCutter.Controls.Add(this.videoView);
            this.tabPageCutter.Controls.Add(this.btnOpenVideo);
            this.tabPageCutter.Controls.Add(this.panelSeek);
            this.tabPageCutter.Controls.Add(this.label1);
            this.tabPageCutter.Controls.Add(this.label2);
            this.tabPageCutter.Controls.Add(this.label3);
            this.tabPageCutter.Controls.Add(this.label4);
            this.tabPageCutter.Controls.Add(this.trackBarVolume);
            this.tabPageCutter.Controls.Add(this.labelVolVal);
            this.tabPageCutter.Controls.Add(this.btnPlayPause);
            this.tabPageCutter.Controls.Add(this.labelStartHint);
            this.tabPageCutter.Controls.Add(this.txtStartTime);
            this.tabPageCutter.Controls.Add(this.btnSetStart);
            this.tabPageCutter.Controls.Add(this.btnExport);
            this.tabPageCutter.Controls.Add(this.labelEndHint);
            this.tabPageCutter.Controls.Add(this.txtEndTime);
            this.tabPageCutter.Controls.Add(this.btnSetEnd);
            this.tabPageCutter.Controls.Add(this.labelExportProgress);
            this.tabPageCutter.Controls.Add(this.labelRemainingTime);
            this.tabPageCutter.Controls.Add(this.labelExportFolder);
            this.tabPageCutter.Controls.Add(this.txtExportFolder);
            this.tabPageCutter.Controls.Add(this.btnSelectExportFolder);
            this.tabPageCutter.Controls.Add(this.progressBarExport);
            this.tabPageCutter.Controls.Add(this.labelAudioTracks);
            this.tabPageCutter.Controls.Add(this.panelAudioChannels);
            this.tabPageCutter.Location = new System.Drawing.Point(4, 22);
            this.tabPageCutter.Name = "tabPageCutter";
            this.tabPageCutter.Size = new System.Drawing.Size(938, 624);
            this.tabPageCutter.TabIndex = 0;
            this.tabPageCutter.Text = "Cutter";
            // 
            // videoView
            // 
            this.videoView.BackColor = System.Drawing.Color.Black;
            this.videoView.Location = new System.Drawing.Point(12, 50);
            this.videoView.MediaPlayer = null;
            this.videoView.Name = "videoView";
            this.videoView.Size = new System.Drawing.Size(914, 370);
            this.videoView.TabIndex = 0;
            // 
            // btnOpenVideo
            // 
            this.btnOpenVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnOpenVideo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnOpenVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenVideo.ForeColor = System.Drawing.Color.White;
            this.btnOpenVideo.Location = new System.Drawing.Point(12, 14);
            this.btnOpenVideo.Name = "btnOpenVideo";
            this.btnOpenVideo.Size = new System.Drawing.Size(110, 28);
            this.btnOpenVideo.TabIndex = 1;
            this.btnOpenVideo.Text = "📂  Open Video";
            this.btnOpenVideo.UseVisualStyleBackColor = false;
            this.btnOpenVideo.Click += new System.EventHandler(this.btnOpenVideo_Click);
            //
            // panelSeek
            //
            this.panelSeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelSeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelSeek.Location = new System.Drawing.Point(10, 430);
            this.panelSeek.Name = "panelSeek";
            this.panelSeek.Size = new System.Drawing.Size(916, 36);
            this.panelSeek.TabIndex = 4;
            this.panelSeek.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSeek_Paint);
            this.panelSeek.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSeek_MouseDown);
            this.panelSeek.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSeek_MouseMove);
            this.panelSeek.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSeek_MouseUp);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(12, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(846, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "00:00:00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(423, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "00:00:00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(12, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Volume";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.trackBarVolume.Location = new System.Drawing.Point(65, 483);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(130, 45);
            this.trackBarVolume.TabIndex = 10;
            this.trackBarVolume.Value = 100;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // labelVolVal
            // 
            this.labelVolVal.Font = new System.Drawing.Font("Consolas", 8F);
            this.labelVolVal.ForeColor = System.Drawing.Color.Silver;
            this.labelVolVal.Location = new System.Drawing.Point(200, 490);
            this.labelVolVal.Name = "labelVolVal";
            this.labelVolVal.Size = new System.Drawing.Size(36, 18);
            this.labelVolVal.TabIndex = 13;
            this.labelVolVal.Text = "100";
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.btnPlayPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPlayPause.ForeColor = System.Drawing.Color.White;
            this.btnPlayPause.Location = new System.Drawing.Point(404, 497);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(120, 30);
            this.btnPlayPause.TabIndex = 2;
            this.btnPlayPause.Text = "▶  Play";
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // labelStartHint
            // 
            this.labelStartHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.labelStartHint.ForeColor = System.Drawing.Color.Silver;
            this.labelStartHint.Location = new System.Drawing.Point(12, 522);
            this.labelStartHint.Name = "labelStartHint";
            this.labelStartHint.Size = new System.Drawing.Size(100, 14);
            this.labelStartHint.TabIndex = 14;
            this.labelStartHint.Text = "Cut Start";
            // 
            // txtStartTime
            // 
            this.txtStartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtStartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartTime.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtStartTime.ForeColor = System.Drawing.Color.White;
            this.txtStartTime.Location = new System.Drawing.Point(12, 538);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(100, 22);
            this.txtStartTime.TabIndex = 5;
            // 
            // btnSetStart
            // 
            this.btnSetStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSetStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSetStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetStart.ForeColor = System.Drawing.Color.White;
            this.btnSetStart.Location = new System.Drawing.Point(118, 537);
            this.btnSetStart.Name = "btnSetStart";
            this.btnSetStart.Size = new System.Drawing.Size(80, 24);
            this.btnSetStart.TabIndex = 3;
            this.btnSetStart.Text = "Set Start";
            this.btnSetStart.UseVisualStyleBackColor = false;
            this.btnSetStart.Click += new System.EventHandler(this.btnSetStart_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(384, 533);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(160, 34);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "⬇  Export Cut";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // labelEndHint
            // 
            this.labelEndHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.labelEndHint.ForeColor = System.Drawing.Color.Silver;
            this.labelEndHint.Location = new System.Drawing.Point(734, 522);
            this.labelEndHint.Name = "labelEndHint";
            this.labelEndHint.Size = new System.Drawing.Size(100, 14);
            this.labelEndHint.TabIndex = 15;
            this.labelEndHint.Text = "Cut End";
            // 
            // txtEndTime
            // 
            this.txtEndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndTime.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtEndTime.ForeColor = System.Drawing.Color.White;
            this.txtEndTime.Location = new System.Drawing.Point(734, 538);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(100, 22);
            this.txtEndTime.TabIndex = 5;
            // 
            // btnSetEnd
            // 
            this.btnSetEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSetEnd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSetEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetEnd.ForeColor = System.Drawing.Color.White;
            this.btnSetEnd.Location = new System.Drawing.Point(840, 537);
            this.btnSetEnd.Name = "btnSetEnd";
            this.btnSetEnd.Size = new System.Drawing.Size(80, 24);
            this.btnSetEnd.TabIndex = 3;
            this.btnSetEnd.Text = "Set End";
            this.btnSetEnd.UseVisualStyleBackColor = false;
            this.btnSetEnd.Click += new System.EventHandler(this.btnSetEnd_Click);
            // 
            // labelExportProgress
            // 
            this.labelExportProgress.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.labelExportProgress.ForeColor = System.Drawing.Color.Silver;
            this.labelExportProgress.Location = new System.Drawing.Point(12, 598);
            this.labelExportProgress.Name = "labelExportProgress";
            this.labelExportProgress.Size = new System.Drawing.Size(110, 14);
            this.labelExportProgress.TabIndex = 16;
            this.labelExportProgress.Text = "Export Progress";
            // 
            // labelRemainingTime
            // 
            this.labelRemainingTime.Font = new System.Drawing.Font("Consolas", 7.5F);
            this.labelRemainingTime.ForeColor = System.Drawing.Color.Silver;
            this.labelRemainingTime.Location = new System.Drawing.Point(808, 598);
            this.labelRemainingTime.Name = "labelRemainingTime";
            this.labelRemainingTime.Size = new System.Drawing.Size(118, 14);
            this.labelRemainingTime.TabIndex = 18;
            this.labelRemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFullscreen
            // 
            this.btnFullscreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnFullscreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullscreen.ForeColor = System.Drawing.Color.White;
            this.btnFullscreen.Location = new System.Drawing.Point(806, 497);
            this.btnFullscreen.Name = "btnFullscreen";
            this.btnFullscreen.Size = new System.Drawing.Size(114, 28);
            this.btnFullscreen.TabIndex = 22;
            this.btnFullscreen.Text = "⛶  Fullscreen";
            this.btnFullscreen.UseVisualStyleBackColor = false;
            this.btnFullscreen.Click += new System.EventHandler(this.btnFullscreen_Click);
            // 
            // labelExportFolder
            // 
            this.labelExportFolder.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.labelExportFolder.ForeColor = System.Drawing.Color.Silver;
            this.labelExportFolder.Location = new System.Drawing.Point(12, 574);
            this.labelExportFolder.Name = "labelExportFolder";
            this.labelExportFolder.Size = new System.Drawing.Size(68, 14);
            this.labelExportFolder.TabIndex = 19;
            this.labelExportFolder.Text = "Export to:";
            // 
            // txtExportFolder
            // 
            this.txtExportFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtExportFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExportFolder.Font = new System.Drawing.Font("Consolas", 8F);
            this.txtExportFolder.ForeColor = System.Drawing.Color.Silver;
            this.txtExportFolder.Location = new System.Drawing.Point(84, 571);
            this.txtExportFolder.Name = "txtExportFolder";
            this.txtExportFolder.ReadOnly = true;
            this.txtExportFolder.Size = new System.Drawing.Size(688, 20);
            this.txtExportFolder.TabIndex = 20;
            this.txtExportFolder.Text = "(none — will prompt on export)";
            // 
            // btnSelectExportFolder
            // 
            this.btnSelectExportFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSelectExportFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSelectExportFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectExportFolder.ForeColor = System.Drawing.Color.White;
            this.btnSelectExportFolder.Location = new System.Drawing.Point(778, 569);
            this.btnSelectExportFolder.Name = "btnSelectExportFolder";
            this.btnSelectExportFolder.Size = new System.Drawing.Size(148, 22);
            this.btnSelectExportFolder.TabIndex = 21;
            this.btnSelectExportFolder.Text = "📂  Select Folder";
            this.btnSelectExportFolder.UseVisualStyleBackColor = false;
            this.btnSelectExportFolder.Click += new System.EventHandler(this.btnSelectExportFolder_Click);
            // 
            // progressBarExport
            // 
            this.progressBarExport.Location = new System.Drawing.Point(12, 614);
            this.progressBarExport.Name = "progressBarExport";
            this.progressBarExport.Size = new System.Drawing.Size(914, 14);
            this.progressBarExport.TabIndex = 9;
            // 
            // labelAudioTracks
            // 
            this.labelAudioTracks.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelAudioTracks.ForeColor = System.Drawing.Color.Silver;
            this.labelAudioTracks.Location = new System.Drawing.Point(709, 428);
            this.labelAudioTracks.Name = "labelAudioTracks";
            this.labelAudioTracks.Size = new System.Drawing.Size(100, 18);
            this.labelAudioTracks.TabIndex = 17;
            this.labelAudioTracks.Text = "Audio Tracks";
            // 
            // panelAudioChannels
            // 
            this.panelAudioChannels.AutoSize = true;
            this.panelAudioChannels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelAudioChannels.ForeColor = System.Drawing.Color.Snow;
            this.panelAudioChannels.Location = new System.Drawing.Point(128, 12);
            this.panelAudioChannels.Name = "panelAudioChannels";
            this.panelAudioChannels.Size = new System.Drawing.Size(796, 34);
            this.panelAudioChannels.TabIndex = 12;
            // 
            // tabPageFolder
            // 
            this.tabPageFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPageFolder.Controls.Add(this.labelFolder);
            this.tabPageFolder.Controls.Add(this.txtFolderPath);
            this.tabPageFolder.Controls.Add(this.btnBrowseFolder);
            this.tabPageFolder.Controls.Add(this.lstVideos);
            this.tabPageFolder.Controls.Add(this.labelVideoCount);
            this.tabPageFolder.Controls.Add(this.btnDeleteVideo);
            this.tabPageFolder.Location = new System.Drawing.Point(4, 22);
            this.tabPageFolder.Name = "tabPageFolder";
            this.tabPageFolder.Size = new System.Drawing.Size(938, 624);
            this.tabPageFolder.TabIndex = 1;
            this.tabPageFolder.Text = "Folder";
            // 
            // labelFolder
            // 
            this.labelFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelFolder.ForeColor = System.Drawing.Color.Silver;
            this.labelFolder.Location = new System.Drawing.Point(12, 16);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(48, 20);
            this.labelFolder.TabIndex = 0;
            this.labelFolder.Text = "Folder:";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolderPath.ForeColor = System.Drawing.Color.White;
            this.txtFolderPath.Location = new System.Drawing.Point(66, 14);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(744, 20);
            this.txtFolderPath.TabIndex = 1;
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBrowseFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnBrowseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseFolder.ForeColor = System.Drawing.Color.White;
            this.btnBrowseFolder.Location = new System.Drawing.Point(820, 12);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(108, 26);
            this.btnBrowseFolder.TabIndex = 2;
            this.btnBrowseFolder.Text = "📂  Browse...";
            this.btnBrowseFolder.UseVisualStyleBackColor = false;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // lstVideos
            // 
            this.lstVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lstVideos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstVideos.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.lstVideos.ForeColor = System.Drawing.Color.White;
            this.lstVideos.FormattingEnabled = true;
            this.lstVideos.ItemHeight = 15;
            this.lstVideos.Location = new System.Drawing.Point(12, 46);
            this.lstVideos.Name = "lstVideos";
            this.lstVideos.Size = new System.Drawing.Size(916, 542);
            this.lstVideos.TabIndex = 3;
            this.lstVideos.DoubleClick += new System.EventHandler(this.lstVideos_DoubleClick);
            //
            // labelVideoCount
            //
            this.labelVideoCount.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.labelVideoCount.ForeColor = System.Drawing.Color.Silver;
            this.labelVideoCount.Location = new System.Drawing.Point(12, 602);
            this.labelVideoCount.Name = "labelVideoCount";
            this.labelVideoCount.Size = new System.Drawing.Size(600, 14);
            this.labelVideoCount.TabIndex = 4;
            this.labelVideoCount.Text = "Select a folder to browse videos";
            //
            // btnDeleteVideo
            //
            this.btnDeleteVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDeleteVideo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDeleteVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVideo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnDeleteVideo.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVideo.Location = new System.Drawing.Point(762, 596);
            this.btnDeleteVideo.Name = "btnDeleteVideo";
            this.btnDeleteVideo.Size = new System.Drawing.Size(166, 24);
            this.btnDeleteVideo.TabIndex = 5;
            this.btnDeleteVideo.Text = "🗑  Delete Selected";
            this.btnDeleteVideo.UseVisualStyleBackColor = false;
            this.btnDeleteVideo.Click += new System.EventHandler(this.btnDeleteVideo_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(946, 650);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raw Video Cutter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageCutter.ResumeLayout(false);
            this.tabPageCutter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.tabPageFolder.ResumeLayout(false);
            this.tabPageFolder.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCutter;
        private System.Windows.Forms.TabPage tabPageFolder;

        private LibVLCSharp.WinForms.VideoView videoView;
        private System.Windows.Forms.Button btnOpenVideo;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnSetStart;
        private System.Windows.Forms.Panel panelSeek;
        private System.Windows.Forms.Button btnSetEnd;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBarExport;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelVolVal;
        private System.Windows.Forms.FlowLayoutPanel panelAudioChannels;
        private System.Windows.Forms.Label labelAudioTracks;
        private System.Windows.Forms.Label labelExportProgress;
        private System.Windows.Forms.Label labelRemainingTime;
        private System.Windows.Forms.Label labelStartHint;
        private System.Windows.Forms.Label labelEndHint;

        private System.Windows.Forms.Button btnFullscreen;
        private System.Windows.Forms.Label labelExportFolder;
        private System.Windows.Forms.TextBox txtExportFolder;
        private System.Windows.Forms.Button btnSelectExportFolder;

        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.ListBox lstVideos;
        private System.Windows.Forms.Label labelVideoCount;
        private System.Windows.Forms.Button btnDeleteVideo;
    }
}
