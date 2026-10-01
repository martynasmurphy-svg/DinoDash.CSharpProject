using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace trex_game.Difficulties
{

    public abstract class DifficultyLevel
    {
        private int _lives;
        private int _baseSpeed;
        private int _minObstacleGap;
        private int _maxObstaclesOnScreen;
        private string _title;
        private int _questioncount;

        public DifficultyLevel() { }

        // Properties
        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }
        public int questioncount
        {
            get { return _questioncount; }
            set { _questioncount = value; }
        }
        public int BaseSpeed
        {
            get { return _baseSpeed; }
            set { _baseSpeed = value; }
        }

        public int MinObstacleGap
        {
            get { return _minObstacleGap; }
            set { _minObstacleGap = value; }
        }

        public int MaxObstaclesOnScreen
        {
            get { return _maxObstaclesOnScreen; }
            set { _maxObstaclesOnScreen = value; }
        }

        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

      
        public virtual int setLives()
        {
            Lives = 0;
            return Lives;
        }
        public virtual int setquestioncount()
        {
            questioncount = 0;
            return questioncount;
        }

        public virtual int setBaseSpeed()
        {
            BaseSpeed = 0;
            return BaseSpeed;
        }

        public virtual int setMinObstacleGap()
        {
            MinObstacleGap = 0;
            return MinObstacleGap;
        }

        public virtual int setMaxObstaclesOnScreen()
        {
            MaxObstaclesOnScreen = 0;
            return MaxObstaclesOnScreen;
        }

        public virtual string setTitle()
        {
            title = "";
            return title;
        }

        public virtual int GetSpeedMultiplier(int score)
        {
            return 0;
        }
    }




}






