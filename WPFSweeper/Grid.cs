using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSweeper
{
    //all the variables and constructor of Grid
    public partial class Game
    {
        public partial class Grid
        {
            /// <summary>
            /// The lovely grid itself
            /// </summary>
            private Cell[,] cellGrid
            {
                get { return cellGrid; }
                set { cellGrid = new Cell[(int)difficulty, (int)difficulty]; }
            }

            /// <summary>
            /// The difficulty of the game
            /// </summary>
            public Difficulty difficulty { get; private set; }
            /// <summary>
            /// Counter of how many mines are left
            /// </summary>
            public int MineLeft { get; private set; }
            /// <summary>
            /// Initialize the grid
            /// </summary>
            /// <param name="newGame">whether the player starts a new game</param>
            public Grid(Difficulty difficulty, bool newGame = true)
            {
                //initialize the game
                if(newGame)
                {
                    return;
                }
                //load saved game
            }
        }
    }
}
