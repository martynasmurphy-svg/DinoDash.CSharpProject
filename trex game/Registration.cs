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
    public partial class Registration : Form
    {
        private Player _player;
        public Registration(Player player)
        {
            InitializeComponent();
            _player = player;
        }

        //validation method checking textboxes are not empty
        public Boolean notEmpty(string username, string password, string confirmpassword)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(confirmpassword))
            {
                MessageBox.Show("Text boxes cannot be empty");
                return true;
            }
            else
                return false;
        }

        //Create a list to store usernames and passwords
        List<string> passwords = new List<string>();
        List<string> Confirmpasswords = new List<string>();
        List<string> users = new List<string>();


      
  

        private void Registration_Load(object sender, EventArgs e)
        {
            //checks to see if loginDetails text file is not empty
            if (new FileInfo("logindetails.txt.txt").Length != 0)
            {
                //if loginDetails text files is not empty take all usernames and store them in "users" list
                using (StreamReader sr = new StreamReader("logindetails.txt"))
                {
                    String line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        String[] components = line.Split("~".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        users.Add(components[0]);
                    }
                    sr.Close();

                }

            }

        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {
            string username = UsernameTB.Text.Trim();
            string password = PasswordTB.Text.Trim();
            string confirm = ConfirmPasswordTB.Text.Trim();

            // Proper empty check
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            // Load existing users from file
            List<string> users = new List<string>();

            if (File.Exists("LoginDetails.txt"))
            {
                foreach (string line in File.ReadAllLines("LoginDetails.txt"))
                {
                    string[] parts = line.Split('~');
                    if (parts.Length > 0)
                    {
                        users.Add(parts[0].Trim());
                    }
                }
            }

            // Check if username already exists
            if (users.Contains(username))
            {
                MessageBox.Show("Username has already been used. Try again");
                return;
            }

            // Check passwords match
            if (password != confirm)
            {
                MessageBox.Show("Both passwords are not the same. Try again");
                return;
            }

            // Save user
            using (StreamWriter sw = new StreamWriter("LoginDetails.txt", true))
            {
                sw.WriteLine(username + "~" + password);
            }

            MessageBox.Show("Account created successfully");

            this.Close();
            MainMenu mm1 = new MainMenu(_player);
            mm1.Show();
        }
        //main menu btn
        private void LoginBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm(_player);
            lg.Show();
        }
        //main menu btn
        private void ReturnToMainMenu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu(_player);
            mm.Show();
        }
    }
}
