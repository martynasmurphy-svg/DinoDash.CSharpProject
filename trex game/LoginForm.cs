using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace trex_game
{
    public partial class LoginForm : Form
    {
        private Player _player;

        XmlSerializer serializerObject = new XmlSerializer(typeof(Player));

        private void passhidecb_CheckedChanged(object sender, EventArgs e)
        {
            if (passhidecb.Checked)
            {
                // Show password
                PasswordTB.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide password
                PasswordTB.UseSystemPasswordChar = true;
            }
        }
        public LoginForm(Player player)
        {
            InitializeComponent();
            _player = player;
        }
        String[] loginDetails;
        string[] parts;
        Boolean validlogin = false;
        public static Player CurrentPlayer;

        //validation method checking textboxes are not empty
        public Boolean notEmpty(String username, string password)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Text boxes cannot be empty");
                return true;

            }
            else
                return false;

        }
        
 

        //Registration Button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration(_player);
            reg.Show();
        }

        //main menu button
        private void MainMenuBTN_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu(_player);
            mm.Show();

        }
        //LoginBTN
        private void LoginBTN_Click_1(object sender, EventArgs e)
        {
            validlogin = false;

            string username = usernameTB.Text.Trim();
            string password = PasswordTB.Text.Trim();

            // Proper empty check
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            // Check file exists
            if (!File.Exists("LoginDetails.txt"))
            {
                MessageBox.Show("Login file not found.");
                return;
            }

            string[] loginDetails = File.ReadAllLines("LoginDetails.txt");

            foreach (string line in loginDetails)
            {
                string[] parts = line.Split('~');

                // Make sure line is valid
                if (parts.Length < 2) continue;

                if (parts[0].Trim() == username && parts[1].Trim() == password)
                {
                    validlogin = true;

                    MessageBox.Show("Login successful");

                    // Using overloaded constructor to create a Player with specific values
                    CurrentPlayer = new Player(username, 0, "", 0);

                    this.Hide();
                    GameHub gh = new GameHub(CurrentPlayer);
                    gh.Show();

                    return;
                }
            }

            // If no match found
            MessageBox.Show("Username or password is incorrect");
        }

    }
}

