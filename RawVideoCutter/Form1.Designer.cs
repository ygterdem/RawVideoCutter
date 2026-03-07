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
            this.videoView = new LibVLCSharp.WinForms.VideoView();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnSetStart = new System.Windows.Forms.Button();
            this.trackBarSeek = new System.Windows.Forms.TrackBar();
            this.btnSetEnd = new System.Windows.Forms.Button();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarExport = new System.Windows.Forms.ProgressBar();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.labelVolVal = new System.Windows.Forms.Label();
            this.panelAudioChannels = new System.Windows.Forms.FlowLayoutPanel();
            this.labelAudioTracks = new System.Windows.Forms.Label();
            this.labelExportProgress = new System.Windows.Forms.Label();
            this.labelStartHint = new System.Windows.Forms.Label();
            this.labelEndHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // videoView
            // 
            this.videoView.BackColor = System.Drawing.Color.Black;
            this.videoView.Location = new System.Drawing.Point(12, 50);
            this.videoView.MediaPlayer = null;
            this.videoView.Name = "videoView";
            this.videoView.Size = new System.Drawing.Size(922, 370);
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
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.btnPlayPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPlayPause.ForeColor = System.Drawing.Color.White;
            this.btnPlayPause.Location = new System.Drawing.Point(412, 497);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(120, 30);
            this.btnPlayPause.TabIndex = 2;
            this.btnPlayPause.Text = "▶  Play";
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
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
            // trackBarSeek
            // 
            this.trackBarSeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.trackBarSeek.Location = new System.Drawing.Point(10, 428);
            this.trackBarSeek.Name = "trackBarSeek";
            this.trackBarSeek.Size = new System.Drawing.Size(922, 45);
            this.trackBarSeek.TabIndex = 4;
            this.trackBarSeek.Scroll += new System.EventHandler(this.trackBarSeek_Scroll);
            // 
            // btnSetEnd
            // 
            this.btnSetEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSetEnd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSetEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetEnd.ForeColor = System.Drawing.Color.White;
            this.btnSetEnd.Location = new System.Drawing.Point(852, 537);
            this.btnSetEnd.Name = "btnSetEnd";
            this.btnSetEnd.Size = new System.Drawing.Size(80, 24);
            this.btnSetEnd.TabIndex = 3;
            this.btnSetEnd.Text = "Set End";
            this.btnSetEnd.UseVisualStyleBackColor = false;
            this.btnSetEnd.Click += new System.EventHandler(this.btnSetEnd_Click);
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
            // txtEndTime
            // 
            this.txtEndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndTime.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtEndTime.ForeColor = System.Drawing.Color.White;
            this.txtEndTime.Location = new System.Drawing.Point(746, 538);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(100, 22);
            this.txtEndTime.TabIndex = 5;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(392, 533);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(160, 34);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "⬇  Export Cut";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.label2.Location = new System.Drawing.Point(854, 476);
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
            this.label3.Location = new System.Drawing.Point(431, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "00:00:00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarExport
            // 
            this.progressBarExport.Location = new System.Drawing.Point(12, 588);
            this.progressBarExport.Name = "progressBarExport";
            this.progressBarExport.Size = new System.Drawing.Size(922, 18);
            this.progressBarExport.TabIndex = 9;
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
            // panelAudioChannels
            // 
            this.panelAudioChannels.AutoSize = true;
            this.panelAudioChannels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelAudioChannels.ForeColor = System.Drawing.Color.Snow;
            this.panelAudioChannels.Location = new System.Drawing.Point(128, 12);
            this.panelAudioChannels.Name = "panelAudioChannels";
            this.panelAudioChannels.Size = new System.Drawing.Size(804, 32);
            this.panelAudioChannels.TabIndex = 12;
            // 
            // labelAudioTracks
            // 
            this.labelAudioTracks.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelAudioTracks.ForeColor = System.Drawing.Color.Silver;
            this.labelAudioTracks.Location = new System.Drawing.Point(717, 428);
            this.labelAudioTracks.Name = "labelAudioTracks";
            this.labelAudioTracks.Size = new System.Drawing.Size(100, 18);
            this.labelAudioTracks.TabIndex = 17;
            this.labelAudioTracks.Text = "Audio Tracks";
            // 
            // labelExportProgress
            // 
            this.labelExportProgress.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.labelExportProgress.ForeColor = System.Drawing.Color.Silver;
            this.labelExportProgress.Location = new System.Drawing.Point(12, 572);
            this.labelExportProgress.Name = "labelExportProgress";
            this.labelExportProgress.Size = new System.Drawing.Size(110, 14);
            this.labelExportProgress.TabIndex = 16;
            this.labelExportProgress.Text = "Export Progress";
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
            // labelEndHint
            // 
            this.labelEndHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.labelEndHint.ForeColor = System.Drawing.Color.Silver;
            this.labelEndHint.Location = new System.Drawing.Point(746, 522);
            this.labelEndHint.Name = "labelEndHint";
            this.labelEndHint.Size = new System.Drawing.Size(100, 14);
            this.labelEndHint.TabIndex = 15;
            this.labelEndHint.Text = "Cut End";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(946, 618);
            this.Controls.Add(this.videoView);
            this.Controls.Add(this.btnOpenVideo);
            this.Controls.Add(this.trackBarSeek);
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
            this.Controls.Add(this.labelExportProgress);
            this.Controls.Add(this.progressBarExport);
            this.Controls.Add(this.labelAudioTracks);
            this.Controls.Add(this.panelAudioChannels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raw Video Cutter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private LibVLCSharp.WinForms.VideoView videoView;
        private System.Windows.Forms.Button btnOpenVideo;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnSetStart;
        private System.Windows.Forms.TrackBar trackBarSeek;
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
        private System.Windows.Forms.Label labelStartHint;
        private System.Windows.Forms.Label labelEndHint;
    }
}