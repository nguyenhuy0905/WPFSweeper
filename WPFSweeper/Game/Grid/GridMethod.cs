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
            /// <summary>
            /// Add cells to the StackPanel, ready to display now
            /// </summary>
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
            /// <summary>
            /// Randomly add mines to cells
            /// </summary>
            private void DistributeMines()
            {
                Random rng = new();
                for(int i = 0; i < MineLeft; i++) 
                {
                    bool added = false;
                    int x, y;
                    while(!added)
                    {
                        x = rng.Next((int)difficulty * 8 / 5);
                        y = rng.Next((int)difficulty);
                        added = AddMine(x, y);
                    }
                }
            }
            /// <summary>
            /// Helper method to add mine to the specified cell when possible
            /// </summary>
            /// <param name="x">The x position of the cell to be added mine</param>
            /// <param name="y">The y position of the cell to be added mine</param>
            /// <returns>True if mine successfully added, false otherwise</returns>
            private bool AddMine(int x, int y)
            {
                //cannot add in mine if the cell is either opened or already has mines
                if (CellGrid[x][y].HasMine || CellGrid[x][y].IsOpened) return false;
                CellGrid[x][y].HasMine = true;
                CellGrid[x][y].Content = "*";
                UpdateMineSurrounding(x, y);
                return true;
            }
            private bool RemoveMine(int x, int y)
            {
                if (!CellGrid[x][y].HasMine) return false;
                CellGrid[x][y].HasMine = false;
                CellGrid[x][y].Content = "M";
                UpdateMineSurrounding(x, y, false);
                return true;
            }
            /// <summary>
            /// Helper method that increases the indexes of the mined cell and its surroundings by 1
            /// </summary>
            /// <param name="x">x-position of the mine</param>
            /// <param name="y">y-position of the mine</param>
            /// <param name="addMine">Whether you're removing or adding a mine</param>
            private void UpdateMineSurrounding(int x, int y, bool addMine = true)
            {
                for(int xOff = -1; xOff <= 1; xOff++)
                {
                    for( int yOff = -1; yOff <= 1; yOff++)
                    {
                        if((x + xOff >= 0 && x + xOff < (int)difficulty * 8 / 5) && (y + yOff >= 0 && y + yOff < (int)difficulty)) 
                            CellGrid[x + xOff][y + yOff].Index += (addMine) ? 1 : -1;
                    }
                }
            }
        }
    }
}
