namespace RetroAchievementsApp.UserControls
{
    partial class TopTenUsers
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
            this.tableTopTenUsers = new System.Windows.Forms.TableLayoutPanel();
            this.timerTopTenUsers = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tableTopTenUsers
            // 
            this.tableTopTenUsers.ColumnCount = 3;
            this.tableTopTenUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableTopTenUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableTopTenUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableTopTenUsers.Location = new System.Drawing.Point(4, 4);
            this.tableTopTenUsers.Name = "tableTopTenUsers";
            this.tableTopTenUsers.RowCount = 10;
            this.tableTopTenUsers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableTopTenUsers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableTopTenUsers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableTopTenUsers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableTopTenUsers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableTopTenUsers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableTopTenUsers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableTopTenUsers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableTopTenUsers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableTopTenUsers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableTopTenUsers.Size = new System.Drawing.Size(681, 502);
            this.tableTopTenUsers.TabIndex = 0;
            // 
            // timerTopTenUsers
            // 
            this.timerTopTenUsers.Enabled = true;
            this.timerTopTenUsers.Interval = 30000;
            this.timerTopTenUsers.Tick += new System.EventHandler(this.timerTopTenUsers_Tick);
            // 
            // TopTenUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tableTopTenUsers);
            this.Name = "TopTenUsers";
            this.Size = new System.Drawing.Size(688, 509);
            this.Load += new System.EventHandler(this.TopTenUsers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableTopTenUsers;
        private System.Windows.Forms.Timer timerTopTenUsers;


    }
}
