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
            /// The lovely grid itself, 
            /// The first index represents the width (X) and the second represent the height (Y)
            /// </summary>
            private Cell[][] CellGrid
            { get; set; }

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
                    CellGrid = new Cell[(int)difficulty * 8 / 5][];
                    for(int row = 0; row < CellGrid.Length; row++)
                    {
                        CellGrid[row] = new Cell[(int)difficulty];
                    }
                    MineLeft = (int)difficulty * (int)difficulty / 2;
                    GenerateEmptyCells(difficulty);
                    LoadCellsToPanel();
                    DistributeMines();
                    return;
                }
                //load saved game
            }
        }
    }
}
