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
    public partial class GameOver : Form
    {
        
            private Player _player;

            public GameOver(Player player)
            {
                InitializeComponent();
                _player = player;
            }



            
       
        //Leaderboard Button
        private void LeaderBoardBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leaderboard LB = new Leaderboard(_player);
            LB.Show();
        }

        //GameHub Button
        private void GamehubBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameHub GH = new GameHub(_player);
            GH.Show();
        }
    }
}
