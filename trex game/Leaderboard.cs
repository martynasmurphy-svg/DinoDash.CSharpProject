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
using System.Xml.Linq;
using System.Xml.Serialization;

namespace trex_game
{
    public partial class Leaderboard : Form
    {
        private string xmlFilePath = "scores.xml";
        private Player _player;

  

        private List<Player> playerList = new List<Player>();

        public Leaderboard(Player player)
        {
            InitializeComponent();
            LoadScores();
            PopulateGrid();
            DisplayTop3();
            _player = player;
        }

        
        // Load players from XML
        
        private void LoadScores()
        {
            try
            {
                if (!File.Exists(xmlFilePath))
                {
                    playerList = new List<Player>();
                    return;
                }

                playerList = XmlSerialize.ConvertXmlToObjects<Player>(xmlFilePath);

                if (playerList == null)
                    playerList = new List<Player>();

                // Sort highest score first
                playerList = playerList
                    .OrderByDescending(p => p.Score)
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading scores:\n" + ex.Message);
                playerList = new List<Player>();
            }
        }

       
        // Display in DataGrid
        
        private void PopulateGrid()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Score", typeof(int));
            table.Columns.Add("Quiz Score", typeof(int));
           
            foreach (Player p in playerList)
            {
                table.Rows.Add(p.Username, p.Title, p.Score, p.Quizscore);
            }

            dataGridView1.DataSource = table;

            // Clean visual setup
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
        }
        //the podium display
        private void DisplayTop3()
        {
            if (playerList.Count > 0)
                lblFirst.Text = playerList[0].Username + "\n" + playerList[0].Score;

            if (playerList.Count > 1)
                lblSecond.Text = playerList[1].Username + "\n" + playerList[1].Score;

            if (playerList.Count > 2)
                lblThird.Text = playerList[2].Username + "\n" + playerList[2].Score;
        }

        // Remove border 
        private void Leaderboard_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //gamehub button
        private void GameHubBTN_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            GameHub gh = new GameHub(_player);
            gh.Show();
        }


    }
}
