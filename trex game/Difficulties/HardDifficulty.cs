using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trex_game.Difficulties
{
    public class HardDifficulty : DifficultyLevel
    {
        public override int setLives()
        {
            Lives = 1;
            return Lives;
        }

        public override int setBaseSpeed()
        {
            BaseSpeed = 25;
            return BaseSpeed;
        }
        public override int setquestioncount()
        {
            questioncount = 7;
            return Lives;
        }

        public override int setMinObstacleGap()
        {
            MinObstacleGap = 100;
            return MinObstacleGap;
        }

        public override int setMaxObstaclesOnScreen()
        {
            MaxObstaclesOnScreen = 4;
            return MaxObstaclesOnScreen;
        }

        public override string setTitle()
        {
            title = "Apex Predator of the Desert";
            return title;
        }
    }


}

