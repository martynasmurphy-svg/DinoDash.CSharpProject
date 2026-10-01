namespace trex_game
{
    partial class GameHub
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
            this.label1 = new System.Windows.Forms.Label();
            this.GameBTN = new System.Windows.Forms.Button();
            this.MainMenuBTN = new System.Windows.Forms.Button();
            this.LeaderboardPB = new System.Windows.Forms.PictureBox();
            this.TutorialPB = new System.Windows.Forms.PictureBox();
            this.ReviewsPB = new System.Windows.Forms.PictureBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LeaderboardPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TutorialPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewsPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(369, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(792, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Game Hub";
            // 
            // GameBTN
            // 
            this.GameBTN.BackgroundImage = global::trex_game.Properties.Resources.Welcome_btn;
            this.GameBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameBTN.FlatAppearance.BorderSize = 0;
            this.GameBTN.Location = new System.Drawing.Point(478, 515);
            this.GameBTN.Name = "GameBTN";
            this.GameBTN.Size = new System.Drawing.Size(439, 88);
            this.GameBTN.TabIndex = 1;
            this.GameBTN.UseVisualStyleBackColor = true;
            this.GameBTN.Click += new System.EventHandler(this.GameBTN_Click);
            // 
            // MainMenuBTN
            // 
            this.MainMenuBTN.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuBTN.BackgroundImage = global::trex_game.Properties.Resources.LoginBTN;
            this.MainMenuBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenuBTN.FlatAppearance.BorderSize = 0;
            this.MainMenuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuBTN.Location = new System.Drawing.Point(1090, 745);
            this.MainMenuBTN.Name = "MainMenuBTN";
            this.MainMenuBTN.Size = new System.Drawing.Size(259, 98);
            this.MainMenuBTN.TabIndex = 4;
            this.MainMenuBTN.UseVisualStyleBackColor = false;
            this.MainMenuBTN.Click += new System.EventHandler(this.MainMenuBTN_Click);
            // 
            // LeaderboardPB
            // 
            this.LeaderboardPB.BackColor = System.Drawing.Color.Transparent;
            this.LeaderboardPB.Image = global::trex_game.Properties.Resources.leaderboard2;
            this.LeaderboardPB.Location = new System.Drawing.Point(24, 177);
            this.LeaderboardPB.Name = "LeaderboardPB";
            this.LeaderboardPB.Size = new System.Drawing.Size(422, 286);
            this.LeaderboardPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeaderboardPB.TabIndex = 5;
            this.LeaderboardPB.TabStop = false;
            this.LeaderboardPB.Click += new System.EventHandler(this.LeaderboardPB_Click);
            // 
            // TutorialPB
            // 
            this.TutorialPB.BackColor = System.Drawing.Color.Transparent;
            this.TutorialPB.Image = global::trex_game.Properties.Resources.___;
            this.TutorialPB.Location = new System.Drawing.Point(489, 199);
            this.TutorialPB.Name = "TutorialPB";
            this.TutorialPB.Size = new System.Drawing.Size(336, 221);
            this.TutorialPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TutorialPB.TabIndex = 6;
            this.TutorialPB.TabStop = false;
            this.TutorialPB.Click += new System.EventHandler(this.TutorialPB_Click);
            // 
            // ReviewsPB
            // 
            this.ReviewsPB.BackColor = System.Drawing.Color.Transparent;
            this.ReviewsPB.Image = global::trex_game.Properties.Resources.Reviews;
            this.ReviewsPB.Location = new System.Drawing.Point(847, 177);
            this.ReviewsPB.Name = "ReviewsPB";
            this.ReviewsPB.Size = new System.Drawing.Size(526, 286);
            this.ReviewsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReviewsPB.TabIndex = 7;
            this.ReviewsPB.TabStop = false;
            this.ReviewsPB.Click += new System.EventHandler(this.ReviewsPB_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BackgroundImage = global::trex_game.Properties.Resources.logoutbtn1;
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Location = new System.Drawing.Point(397, 659);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(562, 194);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // GameHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trex_game.Properties.Resources.RegBackGroundpng;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1385, 855);
            this.ControlBox = false;
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.ReviewsPB);
            this.Controls.Add(this.TutorialPB);
            this.Controls.Add(this.LeaderboardPB);
            this.Controls.Add(this.MainMenuBTN);
            this.Controls.Add(this.GameBTN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameHub";
            this.Load += new System.EventHandler(this.GameHub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeaderboardPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TutorialPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewsPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GameBTN;
        private System.Windows.Forms.Button MainMenuBTN;
        private System.Windows.Forms.PictureBox LeaderboardPB;
        private System.Windows.Forms.PictureBox TutorialPB;
        private System.Windows.Forms.PictureBox ReviewsPB;
        private System.Windows.Forms.Button logoutBtn;
    }
}