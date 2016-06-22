namespace RetroAchievementsApp.UserControls
{
    partial class GameAchievements
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
            this.pnlAchievements = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnlAchievements
            // 
            this.pnlAchievements.AutoSize = true;
            this.pnlAchievements.Location = new System.Drawing.Point(4, 4);
            this.pnlAchievements.Name = "pnlAchievements";
            this.pnlAchievements.Size = new System.Drawing.Size(630, 21);
            this.pnlAchievements.TabIndex = 0;
            this.pnlAchievements.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlAchievements_ControlAdded);
            // 
            // GameAchievements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnlAchievements);
            this.Name = "GameAchievements";
            this.Size = new System.Drawing.Size(640, 30);
            this.Load += new System.EventHandler(this.GameAchievements_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlAchievements;
    }
}
