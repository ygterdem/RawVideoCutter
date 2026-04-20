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

            this.panelSidebar          = new System.Windows.Forms.Panel();
            this.labelFolder           = new System.Windows.Forms.Label();
            this.txtFolderPath         = new System.Windows.Forms.TextBox();
            this.btnBrowseFolder       = new System.Windows.Forms.Button();
            this.lstVideos             = new System.Windows.Forms.ListBox();
            this.labelVideoCount       = new System.Windows.Forms.Label();
            this.btnDeleteVideo        = new System.Windows.Forms.Button();
            this.panelDivider          = new System.Windows.Forms.Panel();
            this.videoView             = new LibVLCSharp.WinForms.VideoView();
            this.btnOpenVideo          = new System.Windows.Forms.Button();
            this.panelAudioChannels    = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFullscreen         = new System.Windows.Forms.Button();
            this.panelSeek             = new System.Windows.Forms.Panel();
            this.label1                = new System.Windows.Forms.Label();
            this.label2                = new System.Windows.Forms.Label();
            this.label3                = new System.Windows.Forms.Label();
            this.label4                = new System.Windows.Forms.Label();
            this.trackBarVolume        = new System.Windows.Forms.TrackBar();
            this.labelVolVal           = new System.Windows.Forms.Label();
            this.btnPlayPause          = new System.Windows.Forms.Button();
            this.labelStartHint        = new System.Windows.Forms.Label();
            this.txtStartTime          = new System.Windows.Forms.TextBox();
            this.btnSetStart           = new System.Windows.Forms.Button();
            this.btnExport             = new System.Windows.Forms.Button();
            this.labelEndHint          = new System.Windows.Forms.Label();
            this.txtEndTime            = new System.Windows.Forms.TextBox();
            this.btnSetEnd             = new System.Windows.Forms.Button();
            this.labelExportFolder     = new System.Windows.Forms.Label();
            this.txtExportFolder       = new System.Windows.Forms.TextBox();
            this.btnSelectExportFolder = new System.Windows.Forms.Button();
            this.labelExportProgress   = new System.Windows.Forms.Label();
            this.labelRemainingTime    = new System.Windows.Forms.Label();
            this.progressBarExport     = new System.Windows.Forms.ProgressBar();
            this.labelAudioTracks      = new System.Windows.Forms.Label();
            this.timer1                = new System.Windows.Forms.Timer(this.components);

            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();

            // ── Sidebar panel ────────────────────────────────────────────────
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            this.panelSidebar.Location  = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name      = "panelSidebar";
            this.panelSidebar.Size      = new System.Drawing.Size(294, 760);
            this.panelSidebar.TabIndex  = 0;
            this.panelSidebar.Controls.Add(this.labelFolder);
            this.panelSidebar.Controls.Add(this.txtFolderPath);
            this.panelSidebar.Controls.Add(this.btnBrowseFolder);
            this.panelSidebar.Controls.Add(this.lstVideos);
            this.panelSidebar.Controls.Add(this.labelVideoCount);
            this.panelSidebar.Controls.Add(this.btnDeleteVideo);

            // labelFolder — uppercase tracking label
            this.labelFolder.Font      = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.labelFolder.ForeColor = System.Drawing.Color.FromArgb(140, 140, 140);
            this.labelFolder.Location  = new System.Drawing.Point(12, 14);
            this.labelFolder.Name      = "labelFolder";
            this.labelFolder.Size      = new System.Drawing.Size(270, 16);
            this.labelFolder.TabIndex  = 0;
            this.labelFolder.Text      = "SOURCE FOLDER";

            // txtFolderPath
            this.txtFolderPath.BackColor    = System.Drawing.Color.FromArgb(38, 38, 38);
            this.txtFolderPath.BorderStyle  = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolderPath.Font         = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFolderPath.ForeColor    = System.Drawing.Color.FromArgb(210, 210, 210);
            this.txtFolderPath.Location     = new System.Drawing.Point(12, 32);
            this.txtFolderPath.Name         = "txtFolderPath";
            this.txtFolderPath.ReadOnly     = true;
            this.txtFolderPath.Size         = new System.Drawing.Size(198, 23);
            this.txtFolderPath.TabIndex     = 1;

            // btnBrowseFolder
            this.btnBrowseFolder.BackColor                  = System.Drawing.Color.FromArgb(55, 55, 55);
            this.btnBrowseFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75);
            this.btnBrowseFolder.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseFolder.Font                       = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseFolder.ForeColor                  = System.Drawing.Color.FromArgb(210, 210, 210);
            this.btnBrowseFolder.Location                   = new System.Drawing.Point(216, 31);
            this.btnBrowseFolder.Name                       = "btnBrowseFolder";
            this.btnBrowseFolder.Size                       = new System.Drawing.Size(66, 25);
            this.btnBrowseFolder.TabIndex                   = 2;
            this.btnBrowseFolder.Text                       = "Browse";
            this.btnBrowseFolder.UseVisualStyleBackColor    = false;
            this.btnBrowseFolder.Click                     += new System.EventHandler(this.btnBrowseFolder_Click);

            // lstVideos — Segoe UI for readable filenames
            this.lstVideos.BackColor         = System.Drawing.Color.FromArgb(32, 32, 32);
            this.lstVideos.BorderStyle       = System.Windows.Forms.BorderStyle.None;
            this.lstVideos.Font              = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstVideos.ForeColor         = System.Drawing.Color.FromArgb(220, 220, 220);
            this.lstVideos.FormattingEnabled = true;
            this.lstVideos.ItemHeight        = 20;
            this.lstVideos.Location          = new System.Drawing.Point(0, 62);
            this.lstVideos.Name              = "lstVideos";
            this.lstVideos.Size              = new System.Drawing.Size(294, 640);
            this.lstVideos.TabIndex          = 3;
            this.lstVideos.DoubleClick      += new System.EventHandler(this.lstVideos_DoubleClick);

            // labelVideoCount
            this.labelVideoCount.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.labelVideoCount.ForeColor = System.Drawing.Color.FromArgb(130, 130, 130);
            this.labelVideoCount.Location  = new System.Drawing.Point(12, 708);
            this.labelVideoCount.Name      = "labelVideoCount";
            this.labelVideoCount.Size      = new System.Drawing.Size(270, 16);
            this.labelVideoCount.TabIndex  = 4;
            this.labelVideoCount.Text      = "Select a folder to browse videos";

            // btnDeleteVideo
            this.btnDeleteVideo.BackColor                  = System.Drawing.Color.FromArgb(100, 28, 28);
            this.btnDeleteVideo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(130, 38, 38);
            this.btnDeleteVideo.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVideo.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteVideo.ForeColor                  = System.Drawing.Color.FromArgb(240, 200, 200);
            this.btnDeleteVideo.Location                   = new System.Drawing.Point(12, 728);
            this.btnDeleteVideo.Name                       = "btnDeleteVideo";
            this.btnDeleteVideo.Size                       = new System.Drawing.Size(270, 26);
            this.btnDeleteVideo.TabIndex                   = 5;
            this.btnDeleteVideo.Text                       = "🗑  Delete Selected";
            this.btnDeleteVideo.UseVisualStyleBackColor    = false;
            this.btnDeleteVideo.Click                     += new System.EventHandler(this.btnDeleteVideo_Click);

            // ── Divider ──────────────────────────────────────────────────────
            this.panelDivider.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            this.panelDivider.Location  = new System.Drawing.Point(294, 0);
            this.panelDivider.Name      = "panelDivider";
            this.panelDivider.Size      = new System.Drawing.Size(2, 760);
            this.panelDivider.TabIndex  = 99;

            // ── Top bar ──────────────────────────────────────────────────────
            // btnOpenVideo
            this.btnOpenVideo.BackColor                  = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnOpenVideo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(72, 72, 72);
            this.btnOpenVideo.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenVideo.Font                       = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenVideo.ForeColor                  = System.Drawing.Color.FromArgb(210, 210, 210);
            this.btnOpenVideo.Location                   = new System.Drawing.Point(304, 10);
            this.btnOpenVideo.Name                       = "btnOpenVideo";
            this.btnOpenVideo.Size                       = new System.Drawing.Size(110, 28);
            this.btnOpenVideo.TabIndex                   = 10;
            this.btnOpenVideo.Text                       = "📂  Open File";
            this.btnOpenVideo.UseVisualStyleBackColor    = false;
            this.btnOpenVideo.Click                     += new System.EventHandler(this.btnOpenVideo_Click);

            // panelAudioChannels
            this.panelAudioChannels.AutoSize  = true;
            this.panelAudioChannels.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.panelAudioChannels.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.panelAudioChannels.ForeColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.panelAudioChannels.Location  = new System.Drawing.Point(424, 10);
            this.panelAudioChannels.Name      = "panelAudioChannels";
            this.panelAudioChannels.Size      = new System.Drawing.Size(622, 30);
            this.panelAudioChannels.TabIndex  = 11;

            // labelAudioTracks (hidden)
            this.labelAudioTracks.Location = new System.Drawing.Point(0, 0);
            this.labelAudioTracks.Name     = "labelAudioTracks";
            this.labelAudioTracks.Size     = new System.Drawing.Size(1, 1);
            this.labelAudioTracks.TabIndex = 90;
            this.labelAudioTracks.Visible  = false;

            // btnFullscreen
            this.btnFullscreen.BackColor                  = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnFullscreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(72, 72, 72);
            this.btnFullscreen.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullscreen.Font                       = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFullscreen.ForeColor                  = System.Drawing.Color.FromArgb(210, 210, 210);
            this.btnFullscreen.Location                   = new System.Drawing.Point(1154, 10);
            this.btnFullscreen.Name                       = "btnFullscreen";
            this.btnFullscreen.Size                       = new System.Drawing.Size(116, 28);
            this.btnFullscreen.TabIndex                   = 12;
            this.btnFullscreen.Text                       = "⛶  Fullscreen";
            this.btnFullscreen.UseVisualStyleBackColor    = false;
            this.btnFullscreen.Click                     += new System.EventHandler(this.btnFullscreen_Click);

            // ── Video view ───────────────────────────────────────────────────
            this.videoView.BackColor   = System.Drawing.Color.Black;
            this.videoView.Location    = new System.Drawing.Point(304, 46);
            this.videoView.MediaPlayer = null;
            this.videoView.Name        = "videoView";
            this.videoView.Size        = new System.Drawing.Size(966, 484);
            this.videoView.TabIndex    = 13;

            // ── Seek bar ─────────────────────────────────────────────────────
            this.panelSeek.BackColor  = System.Drawing.Color.FromArgb(30, 30, 30);
            this.panelSeek.Cursor     = System.Windows.Forms.Cursors.Hand;
            this.panelSeek.Location   = new System.Drawing.Point(304, 538);
            this.panelSeek.Name       = "panelSeek";
            this.panelSeek.Size       = new System.Drawing.Size(966, 36);
            this.panelSeek.TabIndex   = 14;
            this.panelSeek.Paint     += new System.Windows.Forms.PaintEventHandler(this.panelSeek_Paint);
            this.panelSeek.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSeek_MouseDown);
            this.panelSeek.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSeek_MouseMove);
            this.panelSeek.MouseUp   += new System.Windows.Forms.MouseEventHandler(this.panelSeek_MouseUp);

            // ── Time labels — Consolas for fixed-width digit alignment ────────
            this.label1.Font      = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(0, 140, 255);
            this.label1.Location  = new System.Drawing.Point(304, 578);
            this.label1.Name      = "label1";
            this.label1.Size      = new System.Drawing.Size(90, 20);
            this.label1.TabIndex  = 15;
            this.label1.Text      = "00:00:00";

            this.label3.Font      = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location  = new System.Drawing.Point(742, 578);
            this.label3.Name      = "label3";
            this.label3.Size      = new System.Drawing.Size(90, 20);
            this.label3.TabIndex  = 16;
            this.label3.Text      = "00:00:00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.label2.Font      = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(220, 80, 80);
            this.label2.Location  = new System.Drawing.Point(1180, 578);
            this.label2.Name      = "label2";
            this.label2.Size      = new System.Drawing.Size(90, 20);
            this.label2.TabIndex  = 17;
            this.label2.Text      = "00:00:00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ── Volume ───────────────────────────────────────────────────────
            this.label4.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(155, 155, 155);
            this.label4.Location  = new System.Drawing.Point(304, 607);
            this.label4.Name      = "label4";
            this.label4.Size      = new System.Drawing.Size(52, 18);
            this.label4.TabIndex  = 18;
            this.label4.Text      = "Volume";

            this.trackBarVolume.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.trackBarVolume.Location  = new System.Drawing.Point(360, 599);
            this.trackBarVolume.Maximum   = 100;
            this.trackBarVolume.Name      = "trackBarVolume";
            this.trackBarVolume.Size      = new System.Drawing.Size(130, 45);
            this.trackBarVolume.TabIndex  = 19;
            this.trackBarVolume.Value     = 100;
            this.trackBarVolume.Scroll   += new System.EventHandler(this.trackBarVolume_Scroll);

            this.labelVolVal.Font      = new System.Drawing.Font("Consolas", 10F);
            this.labelVolVal.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
            this.labelVolVal.Location  = new System.Drawing.Point(496, 607);
            this.labelVolVal.Name      = "labelVolVal";
            this.labelVolVal.Size      = new System.Drawing.Size(40, 20);
            this.labelVolVal.TabIndex  = 20;
            this.labelVolVal.Text      = "100";

            // ── Play/Pause ───────────────────────────────────────────────────
            this.btnPlayPause.BackColor                  = System.Drawing.Color.FromArgb(0, 84, 166);
            this.btnPlayPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnPlayPause.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Font                       = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlayPause.ForeColor                  = System.Drawing.Color.White;
            this.btnPlayPause.Location                   = new System.Drawing.Point(727, 599);
            this.btnPlayPause.Name                       = "btnPlayPause";
            this.btnPlayPause.Size                       = new System.Drawing.Size(120, 32);
            this.btnPlayPause.TabIndex                   = 21;
            this.btnPlayPause.Text                       = "▶  Play";
            this.btnPlayPause.UseVisualStyleBackColor    = false;
            this.btnPlayPause.Click                     += new System.EventHandler(this.btnPlayPause_Click);

            // ── Cut start ────────────────────────────────────────────────────
            this.labelStartHint.Font      = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.labelStartHint.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.labelStartHint.Location  = new System.Drawing.Point(304, 645);
            this.labelStartHint.Name      = "labelStartHint";
            this.labelStartHint.Size      = new System.Drawing.Size(80, 14);
            this.labelStartHint.TabIndex  = 22;
            this.labelStartHint.Text      = "CUT START";

            this.txtStartTime.BackColor   = System.Drawing.Color.FromArgb(40, 40, 40);
            this.txtStartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartTime.Font        = new System.Drawing.Font("Consolas", 11F);
            this.txtStartTime.ForeColor   = System.Drawing.Color.White;
            this.txtStartTime.Location    = new System.Drawing.Point(304, 661);
            this.txtStartTime.Name        = "txtStartTime";
            this.txtStartTime.Size        = new System.Drawing.Size(104, 24);
            this.txtStartTime.TabIndex    = 23;

            this.btnSetStart.BackColor                  = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnSetStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(72, 72, 72);
            this.btnSetStart.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetStart.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSetStart.ForeColor                  = System.Drawing.Color.FromArgb(50, 210, 90);
            this.btnSetStart.Location                   = new System.Drawing.Point(414, 660);
            this.btnSetStart.Name                       = "btnSetStart";
            this.btnSetStart.Size                       = new System.Drawing.Size(80, 26);
            this.btnSetStart.TabIndex                   = 24;
            this.btnSetStart.Text                       = "[ Set";
            this.btnSetStart.UseVisualStyleBackColor    = false;
            this.btnSetStart.Click                     += new System.EventHandler(this.btnSetStart_Click);

            // ── Export button ────────────────────────────────────────────────
            this.btnExport.BackColor                  = System.Drawing.Color.FromArgb(28, 108, 28);
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(38, 148, 38);
            this.btnExport.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font                       = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor                  = System.Drawing.Color.White;
            this.btnExport.Location                   = new System.Drawing.Point(697, 651);
            this.btnExport.Name                       = "btnExport";
            this.btnExport.Size                       = new System.Drawing.Size(180, 38);
            this.btnExport.TabIndex                   = 25;
            this.btnExport.Text                       = "⬇  Export Cut";
            this.btnExport.UseVisualStyleBackColor    = false;
            this.btnExport.Click                     += new System.EventHandler(this.btnExport_Click);

            // ── Cut end ──────────────────────────────────────────────────────
            this.labelEndHint.Font      = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.labelEndHint.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.labelEndHint.Location  = new System.Drawing.Point(1090, 645);
            this.labelEndHint.Name      = "labelEndHint";
            this.labelEndHint.Size      = new System.Drawing.Size(80, 14);
            this.labelEndHint.TabIndex  = 26;
            this.labelEndHint.Text      = "CUT END";

            this.txtEndTime.BackColor   = System.Drawing.Color.FromArgb(40, 40, 40);
            this.txtEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndTime.Font        = new System.Drawing.Font("Consolas", 11F);
            this.txtEndTime.ForeColor   = System.Drawing.Color.White;
            this.txtEndTime.Location    = new System.Drawing.Point(1090, 661);
            this.txtEndTime.Name        = "txtEndTime";
            this.txtEndTime.Size        = new System.Drawing.Size(104, 24);
            this.txtEndTime.TabIndex    = 27;

            this.btnSetEnd.BackColor                  = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnSetEnd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(72, 72, 72);
            this.btnSetEnd.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetEnd.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSetEnd.ForeColor                  = System.Drawing.Color.FromArgb(220, 80, 80);
            this.btnSetEnd.Location                   = new System.Drawing.Point(1200, 660);
            this.btnSetEnd.Name                       = "btnSetEnd";
            this.btnSetEnd.Size                       = new System.Drawing.Size(70, 26);
            this.btnSetEnd.TabIndex                   = 28;
            this.btnSetEnd.Text                       = "Set ]";
            this.btnSetEnd.UseVisualStyleBackColor    = false;
            this.btnSetEnd.Click                     += new System.EventHandler(this.btnSetEnd_Click);

            // ── Export folder ────────────────────────────────────────────────
            this.labelExportFolder.Font      = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.labelExportFolder.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.labelExportFolder.Location  = new System.Drawing.Point(304, 700);
            this.labelExportFolder.Name      = "labelExportFolder";
            this.labelExportFolder.Size      = new System.Drawing.Size(80, 14);
            this.labelExportFolder.TabIndex  = 29;
            this.labelExportFolder.Text      = "EXPORT TO";

            this.txtExportFolder.BackColor   = System.Drawing.Color.FromArgb(38, 38, 38);
            this.txtExportFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExportFolder.Font        = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtExportFolder.ForeColor   = System.Drawing.Color.FromArgb(160, 160, 160);
            this.txtExportFolder.Location    = new System.Drawing.Point(304, 716);
            this.txtExportFolder.Name        = "txtExportFolder";
            this.txtExportFolder.ReadOnly    = true;
            this.txtExportFolder.Size        = new System.Drawing.Size(778, 23);
            this.txtExportFolder.TabIndex    = 30;
            this.txtExportFolder.Text        = "(none — will prompt on export)";

            this.btnSelectExportFolder.BackColor                  = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnSelectExportFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(72, 72, 72);
            this.btnSelectExportFolder.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectExportFolder.Font                       = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelectExportFolder.ForeColor                  = System.Drawing.Color.FromArgb(210, 210, 210);
            this.btnSelectExportFolder.Location                   = new System.Drawing.Point(1088, 715);
            this.btnSelectExportFolder.Name                       = "btnSelectExportFolder";
            this.btnSelectExportFolder.Size                       = new System.Drawing.Size(182, 25);
            this.btnSelectExportFolder.TabIndex                   = 31;
            this.btnSelectExportFolder.Text                       = "📂  Select Folder";
            this.btnSelectExportFolder.UseVisualStyleBackColor    = false;
            this.btnSelectExportFolder.Click                     += new System.EventHandler(this.btnSelectExportFolder_Click);

            // ── Progress ─────────────────────────────────────────────────────
            this.labelExportProgress.Font      = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelExportProgress.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.labelExportProgress.Location  = new System.Drawing.Point(304, 746);
            this.labelExportProgress.Name      = "labelExportProgress";
            this.labelExportProgress.Size      = new System.Drawing.Size(110, 14);
            this.labelExportProgress.TabIndex  = 32;
            this.labelExportProgress.Text      = "EXPORT PROGRESS";

            this.labelRemainingTime.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.labelRemainingTime.ForeColor = System.Drawing.Color.FromArgb(155, 155, 155);
            this.labelRemainingTime.Location  = new System.Drawing.Point(1050, 746);
            this.labelRemainingTime.Name      = "labelRemainingTime";
            this.labelRemainingTime.Size      = new System.Drawing.Size(220, 14);
            this.labelRemainingTime.TabIndex  = 33;
            this.labelRemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.progressBarExport.Location = new System.Drawing.Point(304, 742);
            this.progressBarExport.Name     = "progressBarExport";
            this.progressBarExport.Size     = new System.Drawing.Size(966, 12);
            this.progressBarExport.TabIndex = 34;

            // ── Timer ────────────────────────────────────────────────────────
            this.timer1.Enabled  = true;
            this.timer1.Interval = 500;
            this.timer1.Tick    += new System.EventHandler(this.timer1_Tick);

            // ── Form ─────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ClientSize          = new System.Drawing.Size(1280, 760);
            this.Font                = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview          = true;
            this.Icon                = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name                = "Form1";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "Raw Video Cutter";
            this.Load               += new System.EventHandler(this.Form1_Load);

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

            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
        }

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
        private System.Windows.Forms.ProgressBar progressBarExport;
        private System.Windows.Forms.Timer     timer1;
    }
}
