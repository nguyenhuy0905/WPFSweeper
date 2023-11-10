using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSweeper
{
    public partial class Game
    {
        public Game(Difficulty difficulty)
        {
            Timer = 0;
            grid = new Grid(difficulty);
        }

        public void Begin()
        {
            //TODO: Set an area to be free of mine, and open all of them up
        }

        public void Continue()
        {
            //TODO: Implement function to continue a saved/paused game
        }

        public void UpdateTimer()
        {
            //TODO: Tick the clock
        }
    }
}
