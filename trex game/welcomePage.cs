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
    
    public partial class welcomePage : Form
    {
        private Player _player;
        public welcomePage(Player player)
        {
            InitializeComponent();
            _player = player;
        }

        //Start Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu(_player);
            mm.Show();
        }
    }
}
