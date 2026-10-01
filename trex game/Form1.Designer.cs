namespace trex_game
{
    partial class Form1
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
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.trex = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.obstacle1B = new System.Windows.Forms.PictureBox();
            this.obstacle2B = new System.Windows.Forms.PictureBox();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(22, 31);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(251, 55);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "SCORE- 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameEvent);
            // 
            // obstacle2
            // 
            this.obstacle2.BackColor = System.Drawing.Color.Transparent;
            this.obstacle2.Image = global::trex_game.Properties.Resources.obstacle_2;
            this.obstacle2.Location = new System.Drawing.Point(691, 606);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(149, 60);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle2.TabIndex = 3;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
            // 
            // obstacle1
            // 
            this.obstacle1.BackColor = System.Drawing.Color.Transparent;
            this.obstacle1.Image = global::trex_game.Properties.Resources.obstacle_1;
            this.obstacle1.Location = new System.Drawing.Point(404, 575);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(71, 91);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle1.TabIndex = 2;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle";
            // 
            // trex
            // 
            this.trex.BackColor = System.Drawing.Color.Transparent;
            this.trex.Image = global::trex_game.Properties.Resources.running;
            this.trex.Location = new System.Drawing.Point(101, 548);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(85, 108);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trex.TabIndex = 1;
            this.trex.TabStop = false;
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Transparent;
            this.floor.BackgroundImage = global::trex_game.Properties.Resources.Desert_sand;
            this.floor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.floor.Location = new System.Drawing.Point(1, 662);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(1400, 115);
            this.floor.TabIndex = 0;
            this.floor.TabStop = false;
            // 
            // obstacle1B
            // 
            this.obstacle1B.BackColor = System.Drawing.Color.Transparent;
            this.obstacle1B.Image = global::trex_game.Properties.Resources.obstacle_1;
            this.obstacle1B.Location = new System.Drawing.Point(272, 575);
            this.obstacle1B.Name = "obstacle1B";
            this.obstacle1B.Size = new System.Drawing.Size(71, 91);
            this.obstacle1B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle1B.TabIndex = 5;
            this.obstacle1B.TabStop = false;
            this.obstacle1B.Tag = "obstacle";
            // 
            // obstacle2B
            // 
            this.obstacle2B.BackColor = System.Drawing.Color.Transparent;
            this.obstacle2B.Image = global::trex_game.Properties.Resources.obstacle_2;
            this.obstacle2B.Location = new System.Drawing.Point(1177, 606);
            this.obstacle2B.Name = "obstacle2B";
            this.obstacle2B.Size = new System.Drawing.Size(149, 60);
            this.obstacle2B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle2B.TabIndex = 6;
            this.obstacle2B.TabStop = false;
            this.obstacle2B.Tag = "obstacle";
            // 
            // life1
            // 
            this.life1.BackColor = System.Drawing.Color.Transparent;
            this.life1.Image = global::trex_game.Properties.Resources.hungerHealth;
            this.life1.Location = new System.Drawing.Point(1266, 12);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(98, 74);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life1.TabIndex = 7;
            this.life1.TabStop = false;
            // 
            // life3
            // 
            this.life3.BackColor = System.Drawing.Color.Transparent;
            this.life3.Image = global::trex_game.Properties.Resources.hungerHealth;
            this.life3.Location = new System.Drawing.Point(996, 12);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(98, 74);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life3.TabIndex = 8;
            this.life3.TabStop = false;
            // 
            // life2
            // 
            this.life2.BackColor = System.Drawing.Color.Transparent;
            this.life2.Image = global::trex_game.Properties.Resources.hungerHealth;
            this.life2.Location = new System.Drawing.Point(1133, 12);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(98, 74);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life2.TabIndex = 9;
            this.life2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trex_game.Properties.Resources.game_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1398, 771);
            this.ControlBox = false;
            this.Controls.Add(this.life2);
            this.Controls.Add(this.life3);
            this.Controls.Add(this.life1);
            this.Controls.Add(this.obstacle2B);
            this.Controls.Add(this.obstacle1B);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.trex);
            this.Controls.Add(this.floor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox trex;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox obstacle1B;
        private System.Windows.Forms.PictureBox obstacle2B;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life2;
    }
}

