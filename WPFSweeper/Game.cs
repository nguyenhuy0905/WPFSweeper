using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// The grid size represented by the difficulty
        /// </summary>
        public enum Difficulty
        {
            Easy = 10,
            Medium = 12,
            Hard = 14
        }
        /// <summary>
        /// Whether the game is loading or not. If true, add a layer of loading screen on top
        /// </summary>
        public bool isLoading { get; private set; }
        /// <summary>
        /// Counts the skillissue of the player
        /// </summary>
        public DateTime timer { get; private set; }
        public Game(Difficulty difficulty, bool newGame)
        {
            isLoading = true;
            grid = new Grid(difficulty, newGame);
        }
    }
}
