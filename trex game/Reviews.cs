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
    public partial class Reviews : Form
    {
        private Player _player;
        public Reviews(Player player)
        {
            InitializeComponent();
            _player = player;
        }

             //gamehub button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameHub GH = new GameHub(_player);
            GH.Show();
        }

 
        
    }
}
