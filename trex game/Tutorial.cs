using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trex_game
{
   
    public partial class Tutorial : Form
    {
        private Player _player;
        public Tutorial(Player player)
        {
            InitializeComponent();
            _player = player;


        }

        private void Tutorial_Load(object sender, EventArgs e)
        {
            string videoPath = Path.Combine(Application.StartupPath, "GAMETUTORIAL.mp4");

            if (File.Exists(videoPath))
            {
                axWindowsMediaPlayer1.settings.autoStart = true;
                axWindowsMediaPlayer1.URL = videoPath;
            }
            else
            {
                MessageBox.Show("Tutorial video not found.");
            }
        }
        //game hub button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameHub gh = new GameHub(_player);
            gh.Show();
        }
    }
}
