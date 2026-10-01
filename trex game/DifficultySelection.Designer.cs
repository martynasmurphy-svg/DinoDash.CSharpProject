namespace trex_game
{
    partial class DifficultySelection
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
            this.PredatorPB = new System.Windows.Forms.PictureBox();
            this.HardPB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EasyPB = new System.Windows.Forms.PictureBox();
            this.MainMenuBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PredatorPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HardPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasyPB)).BeginInit();
            this.SuspendLayout();
            // 
            // PredatorPB
            // 
            this.PredatorPB.BackColor = System.Drawing.Color.Transparent;
            this.PredatorPB.Image = global::trex_game.Properties.Resources.Predator;
            this.PredatorPB.Location = new System.Drawing.Point(481, 489);
            this.PredatorPB.Name = "PredatorPB";
            this.PredatorPB.Size = new System.Drawing.Size(496, 158);
            this.PredatorPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PredatorPB.TabIndex = 4;
            this.PredatorPB.TabStop = false;
            this.PredatorPB.Click += new System.EventHandler(this.PredatorPB_Click);
            // 
            // HardPB
            // 
            this.HardPB.BackColor = System.Drawing.Color.Transparent;
            this.HardPB.Image = global::trex_game.Properties.Resources.umm1;
            this.HardPB.Location = new System.Drawing.Point(481, 674);
            this.HardPB.Name = "HardPB";
            this.HardPB.Size = new System.Drawing.Size(496, 158);
            this.HardPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HardPB.TabIndex = 6;
            this.HardPB.TabStop = false;
            this.HardPB.Click += new System.EventHandler(this.HardPB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(814, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Test Your Limits In the Desert Below!";
            // 
            // EasyPB
            // 
            this.EasyPB.BackColor = System.Drawing.Color.Transparent;
            this.EasyPB.Image = global::trex_game.Properties.Resources.hatchling1;
            this.EasyPB.Location = new System.Drawing.Point(481, 335);
            this.EasyPB.Name = "EasyPB";
            this.EasyPB.Size = new System.Drawing.Size(496, 158);
            this.EasyPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EasyPB.TabIndex = 5;
            this.EasyPB.TabStop = false;
            this.EasyPB.Click += new System.EventHandler(this.EasyPB_Click);
            // 
            // MainMenuBTN
            // 
            this.MainMenuBTN.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuBTN.BackgroundImage = global::trex_game.Properties.Resources.LoginBTN;
            this.MainMenuBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenuBTN.FlatAppearance.BorderSize = 0;
            this.MainMenuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuBTN.Location = new System.Drawing.Point(1209, 25);
            this.MainMenuBTN.Name = "MainMenuBTN";
            this.MainMenuBTN.Size = new System.Drawing.Size(255, 115);
            this.MainMenuBTN.TabIndex = 9;
            this.MainMenuBTN.UseVisualStyleBackColor = false;
            this.MainMenuBTN.Click += new System.EventHandler(this.MainMenuBTN_Click);
            // 
            // DifficultySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trex_game.Properties.Resources.RegBackGroundpng;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1476, 986);
            this.Controls.Add(this.MainMenuBTN);
            this.Controls.Add(this.HardPB);
            this.Controls.Add(this.EasyPB);
            this.Controls.Add(this.PredatorPB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DifficultySelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DifficultySelection";
            ((System.ComponentModel.ISupportInitialize)(this.PredatorPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HardPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasyPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PredatorPB;
        private System.Windows.Forms.PictureBox HardPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox EasyPB;
        private System.Windows.Forms.Button MainMenuBTN;
    }
}