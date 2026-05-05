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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnWinMin = new System.Windows.Forms.Button();
            this.btnWinMax = new System.Windows.Forms.Button();
            this.btnWinClose = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.labelFolder = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.lstVideos = new System.Windows.Forms.ListBox();
            this.labelVideoCount = new System.Windows.Forms.Label();
            this.btnDeleteVideo = new System.Windows.Forms.Button();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.videoView = new LibVLCSharp.WinForms.VideoView();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.panelAudioChannels = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFullscreen = new System.Windows.Forms.Button();
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
            this.labelExportFolder = new System.Windows.Forms.Label();
            this.txtExportFolder = new System.Windows.Forms.TextBox();
            this.btnSelectExportFolder = new System.Windows.Forms.Button();
            this.labelExportProgress = new System.Windows.Forms.Label();
            this.labelRemainingTime = new System.Windows.Forms.Label();
            this.progressBarExport = new System.Windows.Forms.ProgressBar();
            this.labelAudioTracks = new System.Windows.Forms.Label();
            this.chkSplitParts = new System.Windows.Forms.CheckBox();
            this.numSplitMB = new System.Windows.Forms.NumericUpDown();
            this.labelSplitUnit = new System.Windows.Forms.Label();
            this.chkReencode = new System.Windows.Forms.CheckBox();
            this.btnOpenExportFolder = new System.Windows.Forms.Button();
            this.btnOpenLastVideo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTitleBar.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSplitMB)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Controls.Add(this.btnWinMin);
            this.panelTitleBar.Controls.Add(this.btnWinMax);
            this.panelTitleBar.Controls.Add(this.btnWinClose);
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1280, 32);
            this.panelTitleBar.TabIndex = 100;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Gold;
            this.labelTitle.Location = new System.Drawing.Point(12, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(300, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Raw Video Cutter";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnWinMin
            // 
            this.btnWinMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWinMin.BackColor = System.Drawing.Color.Transparent;
            this.btnWinMin.FlatAppearance.BorderSize = 0;
            this.btnWinMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnWinMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinMin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnWinMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnWinMin.Location = new System.Drawing.Point(1142, 0);
            this.btnWinMin.Name = "btnWinMin";
            this.btnWinMin.Size = new System.Drawing.Size(46, 32);
            this.btnWinMin.TabIndex = 1;
            this.btnWinMin.Text = "─";
            this.btnWinMin.UseVisualStyleBackColor = false;
            this.btnWinMin.Click += new System.EventHandler(this.btnWinMin_Click);
            // 
            // btnWinMax
            // 
            this.btnWinMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWinMax.BackColor = System.Drawing.Color.Transparent;
            this.btnWinMax.FlatAppearance.BorderSize = 0;
            this.btnWinMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnWinMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWinMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnWinMax.Location = new System.Drawing.Point(1188, 0);
            this.btnWinMax.Name = "btnWinMax";
            this.btnWinMax.Size = new System.Drawing.Size(46, 32);
            this.btnWinMax.TabIndex = 2;
            this.btnWinMax.Text = "□";
            this.btnWinMax.UseVisualStyleBackColor = false;
            this.btnWinMax.Click += new System.EventHandler(this.btnWinMax_Click);
            // 
            // btnWinClose
            // 
            this.btnWinClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWinClose.BackColor = System.Drawing.Color.Transparent;
            this.btnWinClose.FlatAppearance.BorderSize = 0;
            this.btnWinClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnWinClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnWinClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnWinClose.Location = new System.Drawing.Point(1234, 0);
            this.btnWinClose.Name = "btnWinClose";
            this.btnWinClose.Size = new System.Drawing.Size(46, 32);
            this.btnWinClose.TabIndex = 3;
            this.btnWinClose.Text = "✕";
            this.btnWinClose.UseVisualStyleBackColor = false;
            this.btnWinClose.Click += new System.EventHandler(this.btnWinClose_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panelSidebar.Controls.Add(this.labelFolder);
            this.panelSidebar.Controls.Add(this.txtFolderPath);
            this.panelSidebar.Controls.Add(this.btnBrowseFolder);
            this.panelSidebar.Controls.Add(this.lstVideos);
            this.panelSidebar.Controls.Add(this.labelVideoCount);
            this.panelSidebar.Controls.Add(this.btnDeleteVideo);
            this.panelSidebar.Location = new System.Drawing.Point(0, 32);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(294, 780);
            this.panelSidebar.TabIndex = 0;
            // 
            // labelFolder
            // 
            this.labelFolder.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.labelFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelFolder.Location = new System.Drawing.Point(12, 14);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(270, 16);
            this.labelFolder.TabIndex = 0;
            this.labelFolder.Text = "SOURCE FOLDER";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolderPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFolderPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.txtFolderPath.Location = new System.Drawing.Point(12, 32);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(198, 23);
            this.txtFolderPath.TabIndex = 1;
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnBrowseFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnBrowseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnBrowseFolder.Location = new System.Drawing.Point(216, 31);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(66, 25);
            this.btnBrowseFolder.TabIndex = 2;
            this.btnBrowseFolder.Text = "Browse";
            this.btnBrowseFolder.UseVisualStyleBackColor = false;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // lstVideos
            // 
            this.lstVideos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lstVideos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstVideos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstVideos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lstVideos.FormattingEnabled = true;
            this.lstVideos.ItemHeight = 17;
            this.lstVideos.Location = new System.Drawing.Point(0, 62);
            this.lstVideos.Name = "lstVideos";
            this.lstVideos.Size = new System.Drawing.Size(294, 646);
            this.lstVideos.TabIndex = 3;
            this.lstVideos.DoubleClick += new System.EventHandler(this.lstVideos_DoubleClick);
            // 
            // labelVideoCount
            // 
            this.labelVideoCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVideoCount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.labelVideoCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.labelVideoCount.Location = new System.Drawing.Point(12, 728);
            this.labelVideoCount.Name = "labelVideoCount";
            this.labelVideoCount.Size = new System.Drawing.Size(270, 16);
            this.labelVideoCount.TabIndex = 4;
            this.labelVideoCount.Text = "Select a folder to browse videos";
            // 
            // btnDeleteVideo
            // 
            this.btnDeleteVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDeleteVideo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDeleteVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVideo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDeleteVideo.Location = new System.Drawing.Point(12, 748);
            this.btnDeleteVideo.Name = "btnDeleteVideo";
            this.btnDeleteVideo.Size = new System.Drawing.Size(270, 26);
            this.btnDeleteVideo.TabIndex = 5;
            this.btnDeleteVideo.Text = "🗑  Delete Selected";
            this.btnDeleteVideo.UseVisualStyleBackColor = false;
            this.btnDeleteVideo.Click += new System.EventHandler(this.btnDeleteVideo_Click);
            // 
            // panelDivider
            // 
            this.panelDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelDivider.Location = new System.Drawing.Point(294, 32);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(2, 780);
            this.panelDivider.TabIndex = 99;
            // 
            // videoView
            // 
            this.videoView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoView.BackColor = System.Drawing.Color.Black;
            this.videoView.Location = new System.Drawing.Point(304, 78);
            this.videoView.MediaPlayer = null;
            this.videoView.Name = "videoView";
            this.videoView.Size = new System.Drawing.Size(966, 484);
            this.videoView.TabIndex = 13;
            // 
            // btnOpenVideo
            // 
            this.btnOpenVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnOpenVideo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnOpenVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenVideo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnOpenVideo.Location = new System.Drawing.Point(304, 42);
            this.btnOpenVideo.Name = "btnOpenVideo";
            this.btnOpenVideo.Size = new System.Drawing.Size(110, 28);
            this.btnOpenVideo.TabIndex = 10;
            this.btnOpenVideo.Text = "📂  Open File";
            this.btnOpenVideo.UseVisualStyleBackColor = false;
            this.btnOpenVideo.Click += new System.EventHandler(this.btnOpenVideo_Click);
            // 
            // panelAudioChannels
            // 
            this.panelAudioChannels.AutoSize = true;
            this.panelAudioChannels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelAudioChannels.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panelAudioChannels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panelAudioChannels.Location = new System.Drawing.Point(424, 42);
            this.panelAudioChannels.Name = "panelAudioChannels";
            this.panelAudioChannels.Size = new System.Drawing.Size(622, 30);
            this.panelAudioChannels.TabIndex = 11;
            // 
            // btnFullscreen
            // 
            this.btnFullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullscreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnFullscreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullscreen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFullscreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnFullscreen.Location = new System.Drawing.Point(1154, 42);
            this.btnFullscreen.Name = "btnFullscreen";
            this.btnFullscreen.Size = new System.Drawing.Size(116, 28);
            this.btnFullscreen.TabIndex = 12;
            this.btnFullscreen.Text = "⛶  Fullscreen";
            this.btnFullscreen.UseVisualStyleBackColor = false;
            this.btnFullscreen.Click += new System.EventHandler(this.btnFullscreen_Click);
            // 
            // panelSeek
            // 
            this.panelSeek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelSeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelSeek.Location = new System.Drawing.Point(304, 570);
            this.panelSeek.Name = "panelSeek";
            this.panelSeek.Size = new System.Drawing.Size(966, 36);
            this.panelSeek.TabIndex = 14;
            this.panelSeek.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSeek_Paint);
            this.panelSeek.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSeek_MouseDown);
            this.panelSeek.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSeek_MouseMove);
            this.panelSeek.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSeek_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(304, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(1180, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "00:00:00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(742, 610);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "00:00:00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.label4.Location = new System.Drawing.Point(304, 639);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Volume";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.trackBarVolume.Location = new System.Drawing.Point(360, 631);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(130, 45);
            this.trackBarVolume.TabIndex = 19;
            this.trackBarVolume.Value = 100;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // labelVolVal
            // 
            this.labelVolVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVolVal.Font = new System.Drawing.Font("Consolas", 10F);
            this.labelVolVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.labelVolVal.Location = new System.Drawing.Point(496, 639);
            this.labelVolVal.Name = "labelVolVal";
            this.labelVolVal.Size = new System.Drawing.Size(40, 20);
            this.labelVolVal.TabIndex = 20;
            this.labelVolVal.Text = "100";
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlayPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.btnPlayPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlayPause.ForeColor = System.Drawing.Color.White;
            this.btnPlayPause.Location = new System.Drawing.Point(727, 631);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(120, 32);
            this.btnPlayPause.TabIndex = 21;
            this.btnPlayPause.Text = "▶  Play";
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // labelStartHint
            // 
            this.labelStartHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStartHint.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.labelStartHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.labelStartHint.Location = new System.Drawing.Point(304, 677);
            this.labelStartHint.Name = "labelStartHint";
            this.labelStartHint.Size = new System.Drawing.Size(80, 14);
            this.labelStartHint.TabIndex = 22;
            this.labelStartHint.Text = "CUT START";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtStartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtStartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartTime.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtStartTime.ForeColor = System.Drawing.Color.White;
            this.txtStartTime.Location = new System.Drawing.Point(304, 693);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(104, 25);
            this.txtStartTime.TabIndex = 23;
            // 
            // btnSetStart
            // 
            this.btnSetStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSetStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnSetStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSetStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.btnSetStart.Location = new System.Drawing.Point(414, 692);
            this.btnSetStart.Name = "btnSetStart";
            this.btnSetStart.Size = new System.Drawing.Size(80, 26);
            this.btnSetStart.TabIndex = 24;
            this.btnSetStart.Text = "[ Set";
            this.btnSetStart.UseVisualStyleBackColor = false;
            this.btnSetStart.Click += new System.EventHandler(this.btnSetStart_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(108)))), ((int)(((byte)(28)))));
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(148)))), ((int)(((byte)(38)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(697, 683);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(180, 38);
            this.btnExport.TabIndex = 25;
            this.btnExport.Text = "⬇  Export Cut";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // labelEndHint
            // 
            this.labelEndHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEndHint.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.labelEndHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.labelEndHint.Location = new System.Drawing.Point(1090, 677);
            this.labelEndHint.Name = "labelEndHint";
            this.labelEndHint.Size = new System.Drawing.Size(80, 14);
            this.labelEndHint.TabIndex = 26;
            this.labelEndHint.Text = "CUT END";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndTime.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtEndTime.ForeColor = System.Drawing.Color.White;
            this.txtEndTime.Location = new System.Drawing.Point(1090, 693);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(104, 25);
            this.txtEndTime.TabIndex = 27;
            // 
            // btnSetEnd
            // 
            this.btnSetEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSetEnd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnSetEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSetEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSetEnd.Location = new System.Drawing.Point(1200, 692);
            this.btnSetEnd.Name = "btnSetEnd";
            this.btnSetEnd.Size = new System.Drawing.Size(70, 26);
            this.btnSetEnd.TabIndex = 28;
            this.btnSetEnd.Text = "Set ]";
            this.btnSetEnd.UseVisualStyleBackColor = false;
            this.btnSetEnd.Click += new System.EventHandler(this.btnSetEnd_Click);
            // 
            // labelExportFolder
            // 
            this.labelExportFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelExportFolder.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.labelExportFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.labelExportFolder.Location = new System.Drawing.Point(304, 740);
            this.labelExportFolder.Name = "labelExportFolder";
            this.labelExportFolder.Size = new System.Drawing.Size(80, 14);
            this.labelExportFolder.TabIndex = 29;
            this.labelExportFolder.Text = "EXPORT TO";
            // 
            // txtExportFolder
            // 
            this.txtExportFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtExportFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtExportFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExportFolder.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtExportFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.txtExportFolder.Location = new System.Drawing.Point(304, 756);
            this.txtExportFolder.Name = "txtExportFolder";
            this.txtExportFolder.ReadOnly = true;
            this.txtExportFolder.Size = new System.Drawing.Size(468, 24);
            this.txtExportFolder.TabIndex = 30;
            this.txtExportFolder.Text = "(none — will prompt on export)";
            // 
            // btnSelectExportFolder
            // 
            this.btnSelectExportFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectExportFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSelectExportFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnSelectExportFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectExportFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelectExportFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnSelectExportFolder.Location = new System.Drawing.Point(1088, 755);
            this.btnSelectExportFolder.Name = "btnSelectExportFolder";
            this.btnSelectExportFolder.Size = new System.Drawing.Size(182, 25);
            this.btnSelectExportFolder.TabIndex = 31;
            this.btnSelectExportFolder.Text = "📂  Select Folder";
            this.btnSelectExportFolder.UseVisualStyleBackColor = false;
            this.btnSelectExportFolder.Click += new System.EventHandler(this.btnSelectExportFolder_Click);
            // 
            // labelExportProgress
            // 
            this.labelExportProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelExportProgress.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelExportProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.labelExportProgress.Location = new System.Drawing.Point(304, 786);
            this.labelExportProgress.Name = "labelExportProgress";
            this.labelExportProgress.Size = new System.Drawing.Size(120, 14);
            this.labelExportProgress.TabIndex = 32;
            this.labelExportProgress.Text = "EXPORT PROGRESS";
            // 
            // labelRemainingTime
            // 
            this.labelRemainingTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRemainingTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelRemainingTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.labelRemainingTime.Location = new System.Drawing.Point(1050, 786);
            this.labelRemainingTime.Name = "labelRemainingTime";
            this.labelRemainingTime.Size = new System.Drawing.Size(220, 14);
            this.labelRemainingTime.TabIndex = 33;
            this.labelRemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBarExport
            // 
            this.progressBarExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarExport.Location = new System.Drawing.Point(304, 802);
            this.progressBarExport.Name = "progressBarExport";
            this.progressBarExport.Size = new System.Drawing.Size(966, 14);
            this.progressBarExport.TabIndex = 34;
            // 
            // labelAudioTracks
            // 
            this.labelAudioTracks.Location = new System.Drawing.Point(0, 0);
            this.labelAudioTracks.Name = "labelAudioTracks";
            this.labelAudioTracks.Size = new System.Drawing.Size(1, 1);
            this.labelAudioTracks.TabIndex = 90;
            this.labelAudioTracks.Visible = false;
            // 
            // chkSplitParts
            // 
            this.chkSplitParts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSplitParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.chkSplitParts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.chkSplitParts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.chkSplitParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSplitParts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkSplitParts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chkSplitParts.Location = new System.Drawing.Point(304, 720);
            this.chkSplitParts.Name = "chkSplitParts";
            this.chkSplitParts.Size = new System.Drawing.Size(130, 20);
            this.chkSplitParts.TabIndex = 35;
            this.chkSplitParts.Text = "Split for Discord";
            this.toolTip1.SetToolTip(this.chkSplitParts, "Split the exported file into parts small enough to upload to Discord");
            this.chkSplitParts.UseVisualStyleBackColor = false;
            this.chkSplitParts.CheckedChanged += new System.EventHandler(this.chkSplitParts_CheckedChanged);
            // 
            // numSplitMB
            // 
            this.numSplitMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numSplitMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numSplitMB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSplitMB.Enabled = false;
            this.numSplitMB.Font = new System.Drawing.Font("Consolas", 10F);
            this.numSplitMB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.numSplitMB.Location = new System.Drawing.Point(440, 721);
            this.numSplitMB.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numSplitMB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSplitMB.Name = "numSplitMB";
            this.numSplitMB.Size = new System.Drawing.Size(62, 23);
            this.numSplitMB.TabIndex = 36;
            this.toolTip1.SetToolTip(this.numSplitMB, "Discord free = 25 MB  ·  Nitro = 500 MB");
            this.numSplitMB.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // labelSplitUnit
            // 
            this.labelSplitUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSplitUnit.Enabled = false;
            this.labelSplitUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSplitUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.labelSplitUnit.Location = new System.Drawing.Point(508, 723);
            this.labelSplitUnit.Name = "labelSplitUnit";
            this.labelSplitUnit.Size = new System.Drawing.Size(52, 16);
            this.labelSplitUnit.TabIndex = 37;
            this.labelSplitUnit.Text = "MB / part";
            // 
            // chkReencode
            // 
            this.chkReencode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkReencode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.chkReencode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.chkReencode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.chkReencode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkReencode.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.chkReencode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
            this.chkReencode.Location = new System.Drawing.Point(566, 723);
            this.chkReencode.Name = "chkReencode";
            this.chkReencode.Size = new System.Drawing.Size(200, 18);
            this.chkReencode.TabIndex = 38;
            this.chkReencode.Text = "Re-encode to H.264 (Discord)";
            this.toolTip1.SetToolTip(this.chkReencode, resources.GetString("chkReencode.ToolTip"));
            this.chkReencode.UseVisualStyleBackColor = false;
            // 
            // btnOpenExportFolder
            // 
            this.btnOpenExportFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenExportFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnOpenExportFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnOpenExportFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenExportFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenExportFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnOpenExportFolder.Location = new System.Drawing.Point(778, 755);
            this.btnOpenExportFolder.Name = "btnOpenExportFolder";
            this.btnOpenExportFolder.Size = new System.Drawing.Size(148, 25);
            this.btnOpenExportFolder.TabIndex = 39;
            this.btnOpenExportFolder.Text = "📁  Open Folder";
            this.toolTip1.SetToolTip(this.btnOpenExportFolder, "Open the export destination folder in Explorer");
            this.btnOpenExportFolder.UseVisualStyleBackColor = false;
            this.btnOpenExportFolder.Click += new System.EventHandler(this.btnOpenExportFolder_Click);
            // 
            // btnOpenLastVideo
            // 
            this.btnOpenLastVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenLastVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnOpenLastVideo.Enabled = false;
            this.btnOpenLastVideo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnOpenLastVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenLastVideo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenLastVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnOpenLastVideo.Location = new System.Drawing.Point(932, 755);
            this.btnOpenLastVideo.Name = "btnOpenLastVideo";
            this.btnOpenLastVideo.Size = new System.Drawing.Size(150, 25);
            this.btnOpenLastVideo.TabIndex = 40;
            this.btnOpenLastVideo.Text = "▶  Open Last Video";
            this.toolTip1.SetToolTip(this.btnOpenLastVideo, "Open the last exported clip in your default video player");
            this.btnOpenLastVideo.UseVisualStyleBackColor = false;
            this.btnOpenLastVideo.Click += new System.EventHandler(this.btnOpenLastVideo_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1280, 820);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelDivider);
            this.Controls.Add(this.btnOpenVideo);
            this.Controls.Add(this.panelAudioChannels);
            this.Controls.Add(this.labelAudioTracks);
            this.Controls.Add(this.btnFullscreen);
            this.Controls.Add(this.videoView);
            this.Controls.Add(this.panelSeek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.labelVolVal);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.labelStartHint);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.btnSetStart);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.labelEndHint);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.btnSetEnd);
            this.Controls.Add(this.labelExportFolder);
            this.Controls.Add(this.txtExportFolder);
            this.Controls.Add(this.btnSelectExportFolder);
            this.Controls.Add(this.labelExportProgress);
            this.Controls.Add(this.labelRemainingTime);
            this.Controls.Add(this.progressBarExport);
            this.Controls.Add(this.chkSplitParts);
            this.Controls.Add(this.numSplitMB);
            this.Controls.Add(this.labelSplitUnit);
            this.Controls.Add(this.chkReencode);
            this.Controls.Add(this.btnOpenExportFolder);
            this.Controls.Add(this.btnOpenLastVideo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raw Video Cutter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSplitMB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Title bar
        private System.Windows.Forms.Panel  panelTitleBar;
        private System.Windows.Forms.Label  labelTitle;
        private System.Windows.Forms.Button btnWinMin;
        private System.Windows.Forms.Button btnWinMax;
        private System.Windows.Forms.Button btnWinClose;

        private System.Windows.Forms.Panel   panelSidebar;
        private System.Windows.Forms.Panel   panelDivider;
        private System.Windows.Forms.Label   labelFolder;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button  btnBrowseFolder;
        private System.Windows.Forms.ListBox lstVideos;
        private System.Windows.Forms.Label   labelVideoCount;
        private System.Windows.Forms.Button  btnDeleteVideo;
        private LibVLCSharp.WinForms.VideoView videoView;
        private System.Windows.Forms.Button    btnOpenVideo;
        private System.Windows.Forms.FlowLayoutPanel panelAudioChannels;
        private System.Windows.Forms.Label     labelAudioTracks;
        private System.Windows.Forms.Button    btnFullscreen;
        private System.Windows.Forms.Panel     panelSeek;
        private System.Windows.Forms.Label     label1;
        private System.Windows.Forms.Label     label2;
        private System.Windows.Forms.Label     label3;
        private System.Windows.Forms.Label     label4;
        private System.Windows.Forms.TrackBar  trackBarVolume;
        private System.Windows.Forms.Label     labelVolVal;
        private System.Windows.Forms.Button    btnPlayPause;
        private System.Windows.Forms.Label     labelStartHint;
        private System.Windows.Forms.TextBox   txtStartTime;
        private System.Windows.Forms.Button    btnSetStart;
        private System.Windows.Forms.Button    btnExport;
        private System.Windows.Forms.Label     labelEndHint;
        private System.Windows.Forms.TextBox   txtEndTime;
        private System.Windows.Forms.Button    btnSetEnd;
        private System.Windows.Forms.Label     labelExportFolder;
        private System.Windows.Forms.TextBox   txtExportFolder;
        private System.Windows.Forms.Button    btnSelectExportFolder;
        private System.Windows.Forms.Label     labelExportProgress;
        private System.Windows.Forms.Label     labelRemainingTime;
        private System.Windows.Forms.ProgressBar    progressBarExport;
        private System.Windows.Forms.CheckBox        chkSplitParts;
        private System.Windows.Forms.NumericUpDown   numSplitMB;
        private System.Windows.Forms.Label           labelSplitUnit;
        private System.Windows.Forms.CheckBox        chkReencode;
        private System.Windows.Forms.Button          btnOpenExportFolder;
        private System.Windows.Forms.Button          btnOpenLastVideo;
        private System.Windows.Forms.ToolTip         toolTip1;
        private System.Windows.Forms.Timer           timer1;
    }
}
