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
                for (int x = 0; x < Width; x++)
                {
                    for (int y = 0; y < Height; y++)
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
                for (int x = 0; x < Width; x++)
                {
                    for (int y = 0; y < Height; y++)
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
                for (int i = 0; i < MineLeft; i++)
                {
                    bool added = false;
                    int x, y;
                    while (!added)
                    {
                        x = rng.Next(Width);
                        y = rng.Next(Height);
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
            /// <summary>
            /// Remove the mine at specified location if possible
            /// </summary>
            /// <param name="x">The x-position of the mined cell</param>
            /// <param name="y">The y-position of the mined cell</param>
            /// <returns>True if the mine has been removed, false otherwise</returns>
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
                int xPos, yPos;
                NeighborCellsAction(x, y,
                    (xPos, yPos) =>
                    {
                        CellGrid[xPos][yPos].Index += (addMine) ? 1 : -1;
                    },
                    (xPos, yPos) =>
                    {
                        if (xPos >= 0 && xPos < grid.Width && yPos >= 0 && yPos < grid.Height) return true;
                        return false;
                    });
            }
            /// <summary>
            /// Just a handy one so that I don't have to type this loop again and again and again
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="action"></param>
            /// <param name="condition"></param>
            private static void NeighborCellsAction(int x, int y, Action<int, int> action, Func<int, int, bool> condition)
            {
                for(int xOff = -1; xOff <= 1;  xOff++)
                {
                    for(int yOff = -1; yOff <= 1; yOff++)
                    {
                        if (condition(x + xOff, y + yOff)) action(x + xOff, y + yOff);
                    }
                }
            }
        }
    }
}
