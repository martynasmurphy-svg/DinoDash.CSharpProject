using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trex_game
{
    public partial class GameHub : Form
    {
        public  static Player _currentPlayer;
        public static List<Player> PlayerList = new List<Player>();
        public GameHub(Player player)
        {
            InitializeComponent();
            _currentPlayer = player;
        }
 

        //difficulty selection
        private void GameBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            DifficultySelection ds = new DifficultySelection(_currentPlayer);
            ds.Show();
        }
        //main menu button
        private void MainMenuBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu(_currentPlayer);
            mm.Show();
        }
        //reviews button
        private void ReviewsPB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reviews Rr = new Reviews(_currentPlayer);
            Rr.Show();
        }
        //gamehub load event
        private void GameHub_Load(object sender, EventArgs e)
        {
            string path = "scores.xml";

            PlayerList = XmlSerialize.ConvertXmlToObjects<Player>(path);

            if (PlayerList == null)
                PlayerList = new List<Player>();
        }

        private void LeaderboardPB_Click(object sender, EventArgs e)
        {
            this.Close();
            Leaderboard lb = new Leaderboard(_currentPlayer);
            lb.Show();


        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

             DialogResult result = MessageBox.Show("Are you sure you want to logout?",
             "Logout",
             MessageBoxButtons.YesNo

             );

            if (result == DialogResult.Yes)
            {
                
                _currentPlayer = null;

                MainMenu menu = new MainMenu(_currentPlayer);
                menu.Show();

                this.Close();
            }
        }

        private void TutorialPB_Click(object sender, EventArgs e)
        {
            this.Close();
            Tutorial tt = new Tutorial(_currentPlayer);
            tt.Show();
        }
    }
}
