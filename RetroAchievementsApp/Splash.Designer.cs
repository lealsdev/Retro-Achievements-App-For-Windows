namespace RetroAchievementsApp
{
    partial class Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.pictureBoxRALogo = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorkerUser = new System.ComponentModel.BackgroundWorker();
            this.notifyIconRA = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripRA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.timerPositionChange = new System.Windows.Forms.Timer(this.components);
            this.timerAchievementEarned = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRALogo)).BeginInit();
            this.contextMenuStripRA.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxRALogo
            // 
            this.pictureBoxRALogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRALogo.Image")));
            this.pictureBoxRALogo.Location = new System.Drawing.Point(2, 1);
            this.pictureBoxRALogo.Name = "pictureBoxRALogo";
            this.pictureBoxRALogo.Size = new System.Drawing.Size(519, 95);
            this.pictureBoxRALogo.TabIndex = 0;
            this.pictureBoxRALogo.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.Location = new System.Drawing.Point(2, 103);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Minimum = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(239, 23);
            this.progressBar1.Step = 2;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 1;
            // 
            // backgroundWorkerUser
            // 
            this.backgroundWorkerUser.WorkerReportsProgress = true;
            this.backgroundWorkerUser.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUser_DoWork);
            this.backgroundWorkerUser.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerUser_ProgressChanged);
            this.backgroundWorkerUser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerUser_RunWorkerCompleted);
            // 
            // notifyIconRA
            // 
            this.notifyIconRA.ContextMenuStrip = this.contextMenuStripRA;
            this.notifyIconRA.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconRA.Icon")));
            this.notifyIconRA.Text = "Retro Achievements";
            this.notifyIconRA.Visible = true;
            // 
            // contextMenuStripRA
            // 
            this.contextMenuStripRA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.closeToolStripMenuClose,
            this.toolStripMenuItem1,
            this.toolStripMenuItemHelp,
            this.toolStripMenuItemAbout});
            this.contextMenuStripRA.Name = "contextMenuStripRA";
            this.contextMenuStripRA.Size = new System.Drawing.Size(153, 120);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Enabled = false;
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemOpen.Text = "Open";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // closeToolStripMenuClose
            // 
            this.closeToolStripMenuClose.Name = "closeToolStripMenuClose";
            this.closeToolStripMenuClose.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuClose.Text = "Close";
            this.closeToolStripMenuClose.Click += new System.EventHandler(this.closeToolStripMenuClose_Click);
            // 
            // timerPositionChange
            // 
            this.timerPositionChange.Enabled = true;
            this.timerPositionChange.Interval = 8000;
            this.timerPositionChange.Tick += new System.EventHandler(this.timerPositionChange_Tick);
            // 
            // timerAchievementEarned
            // 
            this.timerAchievementEarned.Interval = 5000;
            this.timerAchievementEarned.Tick += new System.EventHandler(this.timerAchievementEarned_Tick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemHelp.Text = "Help";
            this.toolStripMenuItemHelp.Click += new System.EventHandler(this.toolStripMenuItemHelp_Click);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemAbout.Text = "About";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(524, 129);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBoxRALogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Splash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.Splash_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRALogo)).EndInit();
            this.contextMenuStripRA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRALogo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUser;
        private System.Windows.Forms.NotifyIcon notifyIconRA;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRA;
        internal System.Windows.Forms.Timer timerPositionChange;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuClose;
        private System.Windows.Forms.Timer timerAchievementEarned;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
    }
}