using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trex_game.Difficulties;

namespace trex_game
{
    public partial class DifficultySelection : Form
    {
        private Player currentPlayer;
        private DifficultyLevel selectedDifficulty;

        public DifficultySelection(Player player)
        {
            InitializeComponent();
            currentPlayer = player;
        }


        private void InitialiseDifficulty()
        {
            selectedDifficulty.setLives();
            selectedDifficulty.setquestioncount();
            selectedDifficulty.setBaseSpeed();
            selectedDifficulty.setMinObstacleGap();
            selectedDifficulty.setMaxObstaclesOnScreen();
            selectedDifficulty.setTitle();
        }

        private void StartQuiz()
        {
            QuizForm quiz = new QuizForm(currentPlayer, selectedDifficulty);
            this.Hide();
            quiz.Show();
        }
        //easy button
        private void EasyPB_Click(object sender, EventArgs e)
        {
            selectedDifficulty = new EasyDifficulty();
            InitialiseDifficulty();
            StartQuiz();
        }
        //Medium button
        private void PredatorPB_Click(object sender, EventArgs e)
        {
            selectedDifficulty = new MediumDifficulty();
            InitialiseDifficulty();
            StartQuiz();
        }
        //Hard Button
        private void HardPB_Click(object sender, EventArgs e)
        {
            selectedDifficulty = new HardDifficulty();
            InitialiseDifficulty();
            StartQuiz();
        }
        //main menu button
        private void MainMenuBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu(currentPlayer);
            mm.Show();
        }

    }
}
