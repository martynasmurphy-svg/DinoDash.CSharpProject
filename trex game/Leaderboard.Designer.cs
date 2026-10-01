namespace trex_game
{
    partial class Leaderboard
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblThird = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.podiumPB = new System.Windows.Forms.PictureBox();
            this.GameHubBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podiumPB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1009, 821);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblSecond
            // 
            this.lblSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecond.AutoSize = true;
            this.lblSecond.BackColor = System.Drawing.Color.Transparent;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.ForeColor = System.Drawing.Color.Silver;
            this.lblSecond.Location = new System.Drawing.Point(1436, 980);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(103, 42);
            this.lblSecond.TabIndex = 3;
            this.lblSecond.Text = "2ND:";
            // 
            // lblThird
            // 
            this.lblThird.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThird.AutoSize = true;
            this.lblThird.BackColor = System.Drawing.Color.Transparent;
            this.lblThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThird.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblThird.Location = new System.Drawing.Point(2023, 952);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(103, 42);
            this.lblThird.TabIndex = 4;
            this.lblThird.Text = "3RD:";
            // 
            // lblFirst
            // 
            this.lblFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirst.AutoSize = true;
            this.lblFirst.BackColor = System.Drawing.Color.Transparent;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.ForeColor = System.Drawing.Color.Gold;
            this.lblFirst.Location = new System.Drawing.Point(1742, 798);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(97, 42);
            this.lblFirst.TabIndex = 5;
            this.lblFirst.Text = "1ST:";
            // 
            // podiumPB
            // 
            this.podiumPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.podiumPB.BackColor = System.Drawing.Color.Transparent;
            this.podiumPB.Image = global::trex_game.Properties.Resources.podium;
            this.podiumPB.Location = new System.Drawing.Point(1027, 450);
            this.podiumPB.Name = "podiumPB";
            this.podiumPB.Size = new System.Drawing.Size(784, 572);
            this.podiumPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.podiumPB.TabIndex = 2;
            this.podiumPB.TabStop = false;
            // 
            // GameHubBTN
            // 
            this.GameHubBTN.BackColor = System.Drawing.Color.Transparent;
            this.GameHubBTN.BackgroundImage = global::trex_game.Properties.Resources.Adventure_awaits_at_the_game_hub;
            this.GameHubBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameHubBTN.FlatAppearance.BorderSize = 0;
            this.GameHubBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameHubBTN.Location = new System.Drawing.Point(-8, 12);
            this.GameHubBTN.Name = "GameHubBTN";
            this.GameHubBTN.Size = new System.Drawing.Size(441, 220);
            this.GameHubBTN.TabIndex = 1;
            this.GameHubBTN.UseVisualStyleBackColor = false;
            this.GameHubBTN.Click += new System.EventHandler(this.GameHubBTN_Click_1);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::trex_game.Properties.Resources.RegBackGroundpng;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2161, 1227);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblThird);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.podiumPB);
            this.Controls.Add(this.GameHubBTN);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Leaderboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaderboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podiumPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GameHubBTN;
        private System.Windows.Forms.PictureBox podiumPB;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblThird;
        private System.Windows.Forms.Label lblFirst;
    }
}