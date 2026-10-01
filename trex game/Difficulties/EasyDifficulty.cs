using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trex_game.Difficulties
{
    public class EasyDifficulty : DifficultyLevel
    {
        public override int setLives()
        {
            Lives = 3;
            return Lives;
        }
        public override int setquestioncount()
        {
            questioncount = 3;
            return Lives;
        }

        public override int setBaseSpeed()
        {
            BaseSpeed = 14;
            return BaseSpeed;
        }

        public override int setMinObstacleGap()
        {
            MinObstacleGap = 200;
            return MinObstacleGap;
        }

        public override int setMaxObstaclesOnScreen()
        {
            MaxObstaclesOnScreen = 2;
            return MaxObstaclesOnScreen;
        }

        public override string setTitle()
        {
            title = "Hatchling";
            return title;
        }
    }


}
