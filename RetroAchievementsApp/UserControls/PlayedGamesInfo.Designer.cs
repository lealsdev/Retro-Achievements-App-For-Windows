namespace RetroAchievementsApp.UserControls
{
    partial class PlayedGamesInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlPlayedGames = new System.Windows.Forms.FlowLayoutPanel();
            this.timerPlayedGamesInfo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlPlayedGames
            // 
            this.pnlPlayedGames.AutoSize = true;
            this.pnlPlayedGames.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlPlayedGames.Location = new System.Drawing.Point(3, 3);
            this.pnlPlayedGames.Name = "pnlPlayedGames";
            this.pnlPlayedGames.Size = new System.Drawing.Size(200, 100);
            this.pnlPlayedGames.TabIndex = 0;
            // 
            // timerPlayedGamesInfo
            // 
            this.timerPlayedGamesInfo.Interval = 10000;
            this.timerPlayedGamesInfo.Tick += new System.EventHandler(this.timerPlayedGamesInfo_Tick);
            // 
            // PlayedGamesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnlPlayedGames);
            this.Name = "PlayedGamesInfo";
            this.Size = new System.Drawing.Size(460, 244);
            this.Load += new System.EventHandler(this.PlayedGamesInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlPlayedGames;
        private System.Windows.Forms.Timer timerPlayedGamesInfo;
    }
}
