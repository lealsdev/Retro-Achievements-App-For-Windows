namespace RetroAchievementsApp
{
    partial class Container
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlRA = new System.Windows.Forms.TabControl();
            this.tabTopTenUsers = new System.Windows.Forms.TabPage();
            this.tabPlayedGames = new System.Windows.Forms.TabPage();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.grbLogin = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grbChangeUser = new System.Windows.Forms.GroupBox();
            this.lblRankPosition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblChangeUser = new System.Windows.Forms.Label();
            this.txtChangeUser = new System.Windows.Forms.TextBox();
            this.timerContainer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlRA.SuspendLayout();
            this.grbLogin.SuspendLayout();
            this.grbChangeUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 101);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControlRA
            // 
            this.tabControlRA.Controls.Add(this.tabTopTenUsers);
            this.tabControlRA.Controls.Add(this.tabPlayedGames);
            this.tabControlRA.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlRA.Location = new System.Drawing.Point(2, 107);
            this.tabControlRA.Name = "tabControlRA";
            this.tabControlRA.SelectedIndex = 0;
            this.tabControlRA.Size = new System.Drawing.Size(799, 460);
            this.tabControlRA.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlRA.TabIndex = 1;
            this.tabControlRA.Visible = false;
            // 
            // tabTopTenUsers
            // 
            this.tabTopTenUsers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabTopTenUsers.Location = new System.Drawing.Point(4, 28);
            this.tabTopTenUsers.Name = "tabTopTenUsers";
            this.tabTopTenUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabTopTenUsers.Size = new System.Drawing.Size(791, 428);
            this.tabTopTenUsers.TabIndex = 0;
            this.tabTopTenUsers.Text = "Top Ten Users";
            // 
            // tabPlayedGames
            // 
            this.tabPlayedGames.AutoScroll = true;
            this.tabPlayedGames.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPlayedGames.Location = new System.Drawing.Point(4, 28);
            this.tabPlayedGames.Name = "tabPlayedGames";
            this.tabPlayedGames.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayedGames.Size = new System.Drawing.Size(791, 428);
            this.tabPlayedGames.TabIndex = 1;
            this.tabPlayedGames.Text = "Played Games";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(6, 16);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(127, 19);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Inform your RA User:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(5, 38);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(155, 27);
            this.txtUser.TabIndex = 3;
            // 
            // grbLogin
            // 
            this.grbLogin.Controls.Add(this.btnSave);
            this.grbLogin.Controls.Add(this.lblUser);
            this.grbLogin.Controls.Add(this.txtUser);
            this.grbLogin.Location = new System.Drawing.Point(529, 0);
            this.grbLogin.Name = "grbLogin";
            this.grbLogin.Size = new System.Drawing.Size(171, 101);
            this.grbLogin.TabIndex = 4;
            this.grbLogin.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(85, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grbChangeUser
            // 
            this.grbChangeUser.Controls.Add(this.lblRankPosition);
            this.grbChangeUser.Controls.Add(this.label1);
            this.grbChangeUser.Controls.Add(this.btnChange);
            this.grbChangeUser.Controls.Add(this.lblChangeUser);
            this.grbChangeUser.Controls.Add(this.txtChangeUser);
            this.grbChangeUser.Location = new System.Drawing.Point(529, 0);
            this.grbChangeUser.Name = "grbChangeUser";
            this.grbChangeUser.Size = new System.Drawing.Size(272, 101);
            this.grbChangeUser.TabIndex = 5;
            this.grbChangeUser.TabStop = false;
            // 
            // lblRankPosition
            // 
            this.lblRankPosition.AutoSize = true;
            this.lblRankPosition.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRankPosition.Location = new System.Drawing.Point(177, 41);
            this.lblRankPosition.Name = "lblRankPosition";
            this.lblRankPosition.Size = new System.Drawing.Size(0, 19);
            this.lblRankPosition.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rank Position:";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChange.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(85, 65);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 30);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblChangeUser
            // 
            this.lblChangeUser.AutoSize = true;
            this.lblChangeUser.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeUser.Location = new System.Drawing.Point(6, 16);
            this.lblChangeUser.Name = "lblChangeUser";
            this.lblChangeUser.Size = new System.Drawing.Size(83, 19);
            this.lblChangeUser.TabIndex = 2;
            this.lblChangeUser.Text = "Change User:";
            // 
            // txtChangeUser
            // 
            this.txtChangeUser.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeUser.Location = new System.Drawing.Point(5, 38);
            this.txtChangeUser.Name = "txtChangeUser";
            this.txtChangeUser.Size = new System.Drawing.Size(155, 27);
            this.txtChangeUser.TabIndex = 3;
            // 
            // timerContainer
            // 
            this.timerContainer.Enabled = true;
            this.timerContainer.Interval = 5000;
            this.timerContainer.Tick += new System.EventHandler(this.timerContainer_Tick);
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 571);
            this.Controls.Add(this.grbChangeUser);
            this.Controls.Add(this.grbLogin);
            this.Controls.Add(this.tabControlRA);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Container";
            this.Text = "Retro Achievements";
            this.Load += new System.EventHandler(this.Container_Load);
            this.Resize += new System.EventHandler(this.Container_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlRA.ResumeLayout(false);
            this.grbLogin.ResumeLayout(false);
            this.grbLogin.PerformLayout();
            this.grbChangeUser.ResumeLayout(false);
            this.grbChangeUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabTopTenUsers;
        private System.Windows.Forms.TabPage tabPlayedGames;
        private System.Windows.Forms.TabControl tabControlRA;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.GroupBox grbLogin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grbChangeUser;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblChangeUser;
        private System.Windows.Forms.TextBox txtChangeUser;
        private System.Windows.Forms.Label lblRankPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerContainer;
    }
}

