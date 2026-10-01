using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trex_game
    
{
    [Serializable]
    public class Player
    {
        private string _username;
        private int _score;
        private string _title;
        private int _quizscore;
         
        public Player() { }

        public Player(string username, int score, string title, int quizscore)
        {
            Username = username;
            Score = score;
            Title = title;
            Quizscore = quizscore;

        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }
        public int Quizscore
        {
            get { return _quizscore; }
            set { _quizscore = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }



    }
}
