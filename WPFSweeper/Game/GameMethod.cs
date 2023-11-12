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
            timer = new();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += UpdateTimer;
            timer.Start();
        }

        public void Begin()
        {
            //TODO: Now we start adding mines and all that stuff
        }

        /// <summary>
        /// Continue a saved game after the game has been loaded.
        /// </summary>
        public void Continue()
        {
            //TODO: Implement function to continue a saved/game.
        }

        /// <summary>
        /// Count the time while the game is not paused.
        /// </summary>
        public void UpdateTimer(object sender, EventArgs e)
        {
            if (this.IsPaused) return;
            this.Timer++;
            window.TimerClock.Text = this.Timer.ToString();
        }
    }
}
