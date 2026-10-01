using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using trex_game.Difficulties;

namespace trex_game
{
    public partial class Form1 : Form
    {
        // =====================
        //  MUSIC
        // =====================
        private SoundPlayer player;

        // =====================
        // PLAYER / DIFFICULTY
        // =====================
        private Player _currentPlayer;
        private DifficultyLevel currentDifficulty;

        // =====================
        // MOVEMENT
        // =====================
        bool jumping = false;
        int jumpSpeed = 0;
        int gravity = 6;
        int jumpPower = 30;

        // =====================
        // LIVES
        // =====================
        int lives;
        bool invincible = false;
        int invincibleTime = 0;
        int invincibleDuration = 25;
        PictureBox[] lifeIcons;

        // =====================
        // SCORE
        // =====================
        float scoreCounter = 0;
        int score = 0;

        // =====================
        // GAME SPEED
        // =====================
        int obstacleSpeed;

        // =====================
        // OBSTACLES
        // =====================
        List<PictureBox> obstacles = new List<PictureBox>();
        Random rnd = new Random();

       
        // CONSTRUCTOR
         
        public Form1(Player playerObj, DifficultyLevel difficulty)
        {
            InitializeComponent();

            KeyPreview = true;
            DoubleBuffered = true;

            _currentPlayer = playerObj;
            currentDifficulty = difficulty;

            // LOAD MUSIC
            try
            {
                string path = Path.Combine(Application.StartupPath, "gameMusic.wav");

                if (File.Exists(path))
                {
                    player = new SoundPlayer(path);
                    player.Load();
                    player.PlayLooping();
                }
                else
                {
                    MessageBox.Show("Game music file not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading audio: " + ex.Message);
            }

            obstacles.AddRange(new PictureBox[]
            {
                obstacle1, obstacle1B, obstacle2, obstacle2B
            });

            lifeIcons = new PictureBox[]
            {
                life1, life2, life3
            };

            foreach (PictureBox p in lifeIcons)
            {
                p.BringToFront();
                p.Visible = true;
            }

            ResetGame();
        }

        // =====================
        // MAIN GAME LOOP
        // =====================
        private void GameEvent(object sender, EventArgs e)
        {
            scoreCounter += obstacleSpeed * 0.05f;
            score = (int)scoreCounter;
            scoreText.Text = $"Score: {score}";

            obstacleSpeed = currentDifficulty.BaseSpeed +
                            currentDifficulty.GetSpeedMultiplier(score);

            // INVINCIBILITY FLASH
            if (invincible)
            {
                invincibleTime++;
                trex.Visible = invincibleTime % 4 != 0;

                if (invincibleTime >= invincibleDuration)
                {
                    invincible = false;
                    trex.Visible = true;
                }
            }

            // JUMP
            if (jumping)
            {
                trex.Top += jumpSpeed;
                jumpSpeed += gravity;
            }

            if (trex.Top >= floor.Top - trex.Height)
            {
                trex.Top = floor.Top - trex.Height;
                jumping = false;
                jumpSpeed = 0;
            }

            // OBSTACLES
            foreach (PictureBox o in obstacles)
            {
                if (!o.Visible) continue;

                o.Left -= obstacleSpeed;

                Rectangle trexHitbox = new Rectangle(
                    trex.Left + trex.Width * 20 / 100,
                    trex.Top + trex.Height * 25 / 100,
                    trex.Width * 60 / 100,
                    trex.Height * 65 / 100
                );

                Rectangle obstacleHitbox = new Rectangle(
                    o.Left + o.Width * 25 / 100,
                    o.Top,
                    o.Width * 50 / 100,
                    o.Height
                );

                if (!invincible && trexHitbox.IntersectsWith(obstacleHitbox))
                {
                    LoseLife();
                    return;
                }

                if (o.Right < 0)
                    o.Visible = false;
            }

            TrySpawnObstacle();
        }

        // =====================
        // LIFE SYSTEM
        // =====================
        private void LoseLife()
        {
            lives--;

            if (lives >= 0 && lives < lifeIcons.Length)
                lifeIcons[lives].Image = Properties.Resources.noHungerBAR;

            if (lives <= 0)
            {
                GameOver();
                return;
            }

            invincible = true;
            invincibleTime = 0;
        }

        // =====================
        // SPAWN
        // =====================
        private void TrySpawnObstacle()
        {
            int active = obstacles.Count(o => o.Visible);
            if (active >= currentDifficulty.MaxObstaclesOnScreen) return;

            int farthestX = ClientSize.Width;

            foreach (PictureBox o in obstacles)
                if (o.Visible && o.Right > farthestX)
                    farthestX = o.Right;

            int gap = currentDifficulty.MinObstacleGap + obstacleSpeed * 8;

            if (farthestX > ClientSize.Width + gap)
                return;

            PictureBox spawn = obstacles.FirstOrDefault(o => !o.Visible);

            if (spawn != null)
            {
                spawn.Left = farthestX + rnd.Next(gap, gap + 200);
                spawn.Top = floor.Top - spawn.Height;
                spawn.Visible = true;
            }
        }

        // =====================
        // INPUT
        // =====================
        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
                jumpSpeed = -jumpPower;
            }
        }

        // =====================
        // RESET
        // =====================
        private void ResetGame()
        {
            jumping = false;
            jumpSpeed = 0;
            score = 0;
            scoreCounter = 0;

            obstacleSpeed = currentDifficulty.BaseSpeed;
            lives = currentDifficulty.Lives;

            for (int i = 0; i < lifeIcons.Length; i++)
            {
                lifeIcons[i].Visible = i < lives;
                lifeIcons[i].Image = Properties.Resources.hungerHealth;
            }

            trex.Top = floor.Top - trex.Height;
            trex.Image = Properties.Resources.running;
            trex.Visible = true;

            scoreText.Text = "Score: 0";

            foreach (PictureBox o in obstacles)
                o.Visible = false;

            TrySpawnObstacle();
            TrySpawnObstacle();

            gameTimer.Start();
        }

        // =====================
        // GAME OVER
        // =====================
        private void GameOver()
        {
            //  STOP MUSIC
            player?.Stop();

            SavePlayerScore(
                _currentPlayer.Username,
                score,
                _currentPlayer.Title,
                _currentPlayer.Quizscore
            );

            gameTimer.Stop();
            trex.Image = Properties.Resources.dead;

            this.Hide();
            new GameOver(_currentPlayer).Show();
        }

        // =====================
        // CLOSE FORM 
        // =====================
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            player?.Stop();
            base.OnFormClosing(e);
        }

        // =====================
        // SAVE XML
        // =====================
        private void SavePlayerScore(string username, int score, string title, int quizscore)
        {
            string path = "scores.xml";

            List<Player> players =
                XmlSerialize.ConvertXmlToObjects<Player>(path);

            if (players == null)
            {
                players = new List<Player>();
            }

            players.Add(new Player(username, score, title, quizscore));

            XmlSerialize.SaveObjects(players, path);
        }
    }
}