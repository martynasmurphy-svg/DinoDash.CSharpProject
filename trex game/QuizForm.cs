using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trex_game.Difficulties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace trex_game
{
    public partial class QuizForm : Form
    {
        class Question
        {
            public string Text;
            public string Correct;
            public List<string> Options;
        }

        private Player currentPlayer;
        private DifficultyLevel currentDifficulty;

        private List<Question> quizQuestions = new List<Question>();
        private int currentQuestion = 0;
        private int score = 0;

        public QuizForm(Player player, DifficultyLevel difficulty)
        {
            InitializeComponent();
            currentPlayer = player;
            currentDifficulty = difficulty;

            LoadQuestions();
            ShowQuestion();
        }

        private void LoadQuestions()
        {
            string path = "DAEXAM.txt";

            try
            {
                if (!File.Exists(path))
                {
                    throw new QuizLoadException("Quiz file not found.");
                }

                var lines = File.ReadAllLines(path);
                var rnd = new Random();

                int questionCount = currentDifficulty.questioncount;

                var selected = lines
                    .OrderBy(x => rnd.Next())
                    .Take(questionCount);

                foreach (var line in selected)
                {
                    var parts = line.Split('~');

                    if (parts.Length < 5) continue;

                    var q = new Question
                    {
                        Text = parts[0],
                        Correct = parts[1],
                        Options = new List<string>
                {
                    parts[1],
                    parts[2],
                    parts[3],
                    parts[4]
                }.OrderBy(x => rnd.Next()).ToList()
                    };

                    quizQuestions.Add(q);
                }
            }
            //custom exception
            catch (QuizLoadException ex)
            {
                // closes quiz safely if file missing
                MessageBox.Show(ex.Message);
                this.Close(); 
            }
        }

        private void ShowQuestion()
        {
            if (currentQuestion >= quizQuestions.Count)
            {
                FinishQuiz();
                return;
            }

            var q = quizQuestions[currentQuestion];

            questionlbl.Text = q.Text;

            button1.Text = q.Options[0];
            button2.Text = q.Options[1];
            button3.Text = q.Options[2];
            button4.Text = q.Options[3];
        }

        private void CheckAnswer(string chosen)
        {
            if (chosen == quizQuestions[currentQuestion].Correct)
            {
                score++;
                currentPlayer.Score += 10;
            }

            currentQuestion++;
            ShowQuestion();
        }

        private void FinishQuiz()
        {

            MessageBox.Show($"Quiz finished!\nScore: {score}/{quizQuestions.Count}");

            currentPlayer.Quizscore = score;
            currentPlayer.Title = currentDifficulty.title; 

            this.Hide();

            Form1 f1 = new Form1(currentPlayer, currentDifficulty);
            f1.Show();
        }
        //answer buttons
        private void button1_Click(object sender, EventArgs e) => CheckAnswer(button1.Text);
        private void button2_Click(object sender, EventArgs e) => CheckAnswer(button2.Text);
        private void button3_Click(object sender, EventArgs e) => CheckAnswer(button3.Text);
        private void button4_Click(object sender, EventArgs e) => CheckAnswer(button4.Text);
    }
}

