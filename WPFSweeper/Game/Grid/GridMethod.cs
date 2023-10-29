using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSweeper
{
    //methods of Grid except constructors
    public partial class Game
    {
        public partial class Grid
        {
            /// <summary>
            /// Populate the grid with dead- I mean empty cells
            /// </summary>
            /// <param name="difficulty">The game's difficulty</param>
            private void GenerateEmptyCells(Difficulty difficulty)
            {
                for(int x = 0; x < CellGrid.Length; x++)
                {
                    for(int y = 0;  y < CellGrid[x].Length; y++)
                    {
                        Cell c = new(x, y);
                        CellGrid[x][y] = c;
                    }
                }
            }
            private void LoadCellsToPanel()
            {
                for(int x = 0; x < CellGrid.Length; x++)
                {
                    for(int y = 0;  y < CellGrid[x].Length; y++)
                    {
                        MainWindow.main.GetRow(y).Children.Add(CellGrid[x][y]);
                    }
                }
            }
        }
    }
}
