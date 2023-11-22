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
            this.difficulty = difficulty;
            timer = new();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += UpdateTimer;
            timer.Start();
        }

        /// <summary>
        /// Triggered when a new game is started. A new game is started after the 
        /// first left-click in one of the cells
        /// <list type="number">
        ///     <listheader>
        ///         <term>What is done in this method:</term>
        ///     </listheader>
        ///     <item>
        ///         <term>A mine-free area is created around the clicked cell</term>
        ///     </item>
        ///     <item>
        ///         <term>Mines are distributed in cells other than the mine-free ones</term>
        ///     </item>
        ///     <item>
        ///         <term>The grid is <seealso cref="Grid.InspectGrid">inspected</seealso> to ensure
        ///         no enclosed area are present anymore</term>
        ///     </item>
        ///     <item>
        ///         <term>The game begins. The timer starts to tick, some cells around the first
        ///         clicked cell are opened if they are valid</term>
        ///     </item>
        /// </list>
        /// </summary>
        public void Begin()
        {
            /*
             * TODO: Finish this Begin method
             * 
             */
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

        public void CloseTimer()
        {
            this.timer.Stop();
        }
    }
}
