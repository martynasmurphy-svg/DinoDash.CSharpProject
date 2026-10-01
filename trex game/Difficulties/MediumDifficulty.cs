using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trex_game.Difficulties
{
    public class MediumDifficulty : DifficultyLevel
    {
      
        
            public override int setLives()
            {
                Lives = 1;
                return Lives;
            }

            public override int setBaseSpeed()
            {
                BaseSpeed = 18;
                return BaseSpeed;
            }

            public override int setMinObstacleGap()
            {
                MinObstacleGap = 150;
                return MinObstacleGap;
            }

            public override int setMaxObstaclesOnScreen()
            {
                MaxObstaclesOnScreen = 3;
                return MaxObstaclesOnScreen;
            }
            public override int setquestioncount()
            {
            questioncount = 5;
            return Lives;
            }

        public override string setTitle()
            {
                title = "Predator";
                return title;
            }

    }


}
