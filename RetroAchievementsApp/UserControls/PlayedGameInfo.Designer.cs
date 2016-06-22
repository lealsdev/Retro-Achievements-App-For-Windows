namespace RetroAchievementsApp.UserControls
{
    partial class PlayedGameInfo
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
            this.picGameImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblConsole = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLastTimePlayed = new System.Windows.Forms.Label();
            this.lblPossibleAchievements = new System.Windows.Forms.Label();
            this.lblPossibleScore = new System.Windows.Forms.Label();
            this.lblAchievementsAchieved = new System.Windows.Forms.Label();
            this.lblScoreAchieved = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerPlayedGameInfo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picGameImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picGameImage
            // 
            this.picGameImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGameImage.ImageLocation = "";
            this.picGameImage.Location = new System.Drawing.Point(3, 3);
            this.picGameImage.Name = "picGameImage";
            this.picGameImage.Size = new System.Drawing.Size(98, 92);
            this.picGameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGameImage.TabIndex = 0;
            this.picGameImage.TabStop = false;
            this.picGameImage.Click += new System.EventHandler(this.picGameImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Console:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Time Played:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Possible Achievements:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Possible Score:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Achievements Achieved:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(329, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Score Achieved:";
            // 
            // lblConsole
            // 
            this.lblConsole.AutoSize = true;
            this.lblConsole.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblConsole.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsole.Location = new System.Drawing.Point(163, 3);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(43, 19);
            this.lblConsole.TabIndex = 8;
            this.lblConsole.Text = "label8";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(375, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(43, 19);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "label9";
            // 
            // lblLastTimePlayed
            // 
            this.lblLastTimePlayed.AutoSize = true;
            this.lblLastTimePlayed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLastTimePlayed.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastTimePlayed.Location = new System.Drawing.Point(226, 76);
            this.lblLastTimePlayed.Name = "lblLastTimePlayed";
            this.lblLastTimePlayed.Size = new System.Drawing.Size(47, 19);
            this.lblLastTimePlayed.TabIndex = 10;
            this.lblLastTimePlayed.Text = "label10";
            // 
            // lblPossibleAchievements
            // 
            this.lblPossibleAchievements.AutoSize = true;
            this.lblPossibleAchievements.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPossibleAchievements.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPossibleAchievements.Location = new System.Drawing.Point(254, 26);
            this.lblPossibleAchievements.Name = "lblPossibleAchievements";
            this.lblPossibleAchievements.Size = new System.Drawing.Size(43, 19);
            this.lblPossibleAchievements.TabIndex = 11;
            this.lblPossibleAchievements.Text = "label11";
            // 
            // lblPossibleScore
            // 
            this.lblPossibleScore.AutoSize = true;
            this.lblPossibleScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPossibleScore.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPossibleScore.Location = new System.Drawing.Point(430, 26);
            this.lblPossibleScore.Name = "lblPossibleScore";
            this.lblPossibleScore.Size = new System.Drawing.Size(47, 19);
            this.lblPossibleScore.TabIndex = 12;
            this.lblPossibleScore.Text = "label12";
            // 
            // lblAchievementsAchieved
            // 
            this.lblAchievementsAchieved.AutoSize = true;
            this.lblAchievementsAchieved.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAchievementsAchieved.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchievementsAchieved.Location = new System.Drawing.Point(258, 51);
            this.lblAchievementsAchieved.Name = "lblAchievementsAchieved";
            this.lblAchievementsAchieved.Size = new System.Drawing.Size(47, 19);
            this.lblAchievementsAchieved.TabIndex = 13;
            this.lblAchievementsAchieved.Text = "label13";
            // 
            // lblScoreAchieved
            // 
            this.lblScoreAchieved.AutoSize = true;
            this.lblScoreAchieved.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblScoreAchieved.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreAchieved.Location = new System.Drawing.Point(430, 51);
            this.lblScoreAchieved.Name = "lblScoreAchieved";
            this.lblScoreAchieved.Size = new System.Drawing.Size(48, 19);
            this.lblScoreAchieved.TabIndex = 14;
            this.lblScoreAchieved.Text = "label14";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picGameImage);
            this.panel1.Controls.Add(this.lblScoreAchieved);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAchievementsAchieved);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPossibleScore);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblPossibleAchievements);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblLastTimePlayed);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblConsole);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 100);
            this.panel1.TabIndex = 15;
            // 
            // timerPlayedGameInfo
            // 
            this.timerPlayedGameInfo.Enabled = false;
            this.timerPlayedGameInfo.Interval = 10000;
            this.timerPlayedGameInfo.Tick += new System.EventHandler(this.timerPlayedGameInfo_Tick);
            // 
            // PlayedGameInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Name = "PlayedGameInfo";
            this.Size = new System.Drawing.Size(754, 110);
            this.Load += new System.EventHandler(this.PlayedGameInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGameImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGameImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblConsole;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLastTimePlayed;
        private System.Windows.Forms.Label lblPossibleAchievements;
        private System.Windows.Forms.Label lblPossibleScore;
        private System.Windows.Forms.Label lblAchievementsAchieved;
        private System.Windows.Forms.Label lblScoreAchieved;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerPlayedGameInfo;
    }
}
