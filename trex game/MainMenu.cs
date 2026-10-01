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
    public partial class MainMenu : Form
    {
        private Player _player;
        public MainMenu(Player player)
        {
            InitializeComponent();
            _player = player;
        }
        //Registration
        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration(_player);
            reg.Show();

        }
        //LoginBTN
        private void LoginBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm(_player);
            lf.Show();
        }
        //reviews buttons
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reviews rw = new Reviews(_player);
            rw.Show();
        }
    }
}
