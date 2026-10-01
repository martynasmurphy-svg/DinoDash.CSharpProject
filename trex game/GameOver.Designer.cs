namespace trex_game
{
    partial class GameOver
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
            this.GamehubBTN = new System.Windows.Forms.Button();
            this.LeaderBoardBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GamehubBTN
            // 
            this.GamehubBTN.BackColor = System.Drawing.Color.Transparent;
            this.GamehubBTN.BackgroundImage = global::trex_game.Properties.Resources.Adventure_awaits_at_the_game_hub;
            this.GamehubBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GamehubBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GamehubBTN.Location = new System.Drawing.Point(299, 498);
            this.GamehubBTN.Name = "GamehubBTN";
            this.GamehubBTN.Size = new System.Drawing.Size(390, 258);
            this.GamehubBTN.TabIndex = 0;
            this.GamehubBTN.UseVisualStyleBackColor = false;
            this.GamehubBTN.Click += new System.EventHandler(this.GamehubBTN_Click);
            // 
            // LeaderBoardBTN
            // 
            this.LeaderBoardBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeaderBoardBTN.BackColor = System.Drawing.Color.Transparent;
            this.LeaderBoardBTN.BackgroundImage = global::trex_game.Properties.Resources.leaderboard2;
            this.LeaderBoardBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeaderBoardBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaderBoardBTN.Location = new System.Drawing.Point(717, 521);
            this.LeaderBoardBTN.Name = "LeaderBoardBTN";
            this.LeaderBoardBTN.Size = new System.Drawing.Size(454, 235);
            this.LeaderBoardBTN.TabIndex = 1;
            this.LeaderBoardBTN.UseVisualStyleBackColor = false;
            this.LeaderBoardBTN.Click += new System.EventHandler(this.LeaderBoardBTN_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::trex_game.Properties.Resources.gameoverscreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1797, 1016);
            this.Controls.Add(this.LeaderBoardBTN);
            this.Controls.Add(this.GamehubBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOver";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GamehubBTN;
        private System.Windows.Forms.Button LeaderBoardBTN;
    }
}