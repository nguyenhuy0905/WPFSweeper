using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WPFSweeper
{
    //all the variables of the Game class plus the constructor
    /// <summary>
    /// The game itself
    /// </summary>
    public partial class Game
    {
        /// <summary>
        /// the grid
        /// </summary>
        public Grid grid;
        /// <summary>
        /// The grid height represented by the difficulty.
        /// The corresponding widths are 1.6 times larger
        /// </summary>
        public enum Difficulty
        {
            Easy = 10,
            Medium = 15,
            Hard = 20
        }
        /// <summary>
        /// The difficulty of the game
        /// </summary>
        public static Difficulty difficulty { get; set; }
        /// <summary>
        /// Whether the game is loading or not. If true, add a layer of loading screen on top
        /// </summary>
        public bool isLoading { get; private set; }
        /// <summary>
        /// The timer for the game
        /// </summary>
        public DispatcherTimer timer { get; private set; }
        public Game(Difficulty difficulty, bool newGame = true)
        {
            Game.difficulty = difficulty;
            isLoading = true;
            grid = new Grid(difficulty, newGame);
            //setup the timer
            timer = new();
            timer.Interval = new TimeSpan(0, 0, 1);
#pragma warning disable CS8622
            timer.Tick += new EventHandler(UpdateClock);
#pragma warning restore 
            timer.Start();
            
        }
    }
}
