using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFSweeper
{
    //contains constructor and all methods of Grid
    public partial class Grid
    {
        /// <summary>
        /// Sets up a grid
        /// </summary>
        /// <param name="difficulty">The difficulty of the <see cref="Game">Game</see></param>
        public Grid(Difficulty difficulty)
        {
            //TODO: Finish Grid constructor
            //16 : 10 grid
            this.Width = (int)difficulty * 8/5;
            this.Height = (int)difficulty;
            //1 in 4 cells has mine
            this.NumMine = Width * Height / 4;
            this.grid = new Cell[Width][];
            PopulateGrid();
            AddMines();
        }

        /// <summary>
        /// Helper method to fell the <c>Grid</c> with <c>Cell</c>s
        /// </summary>
        private void PopulateGrid()
        {
            for(int x = 0; x < this.Width; x++)
            {
                //initialize a panel to display the cells and part of the grid
                Cell[] col = new Cell[Height];
                grid[x] = col;
                StackPanel panel = new()
                {
                    Width = 960 / this.Width - 2,
                    Orientation = Orientation.Vertical,                    
                    
                };
                for(int y = 0; y < this.Height; y++)
                {
                    Cell cell = new(x, y, 960 / this.Width - 2);
                    col[y] = cell;
                    panel.Children.Add(cell);
                }
                window.MainStackPanel.Children.Add(panel);
            }
        }

        /// <summary>
        /// Start adding mines to the <see cref="Grid">Grid</see>
        /// </summary>
        private void AddMines()
        {
            //Initialize randomizer
            Random rng = new();
            while(this.NumMine > 0)
            {
                //determine where to add mine
                int xMine = rng.Next(this.Width);
                int yMine = rng.Next(this.Height);
                //grab the cell to be added mine and check whether it already has mine
                Cell addMine = grid[xMine][yMine];
                if (addMine.HasMine) continue;

                //add mine
                addMine.HasMine = true;
                addMine.Content = "*";
                NumMine--;

                //update his neighbors' indeces
                List<Cell> neighbors = GetNeighboringCells(xMine, yMine);
                foreach (Cell neighbor in neighbors)
                {
                    neighbor.Index++;
                    if(!neighbor.HasMine) neighbor.Content = neighbor.Index;
                }
            }
        }
        
        /// <summary>
        /// A helper method that returns a list of neighbors of the <see cref="Cell">Cell</see> specified
        /// </summary>
        /// <param name="x">The x-position of the <see cref="Cell">Cell</see></param>
        /// <param name="y">The y-position of the <see cref="Cell">Cell</see></param>
        /// <returns>A List of neighboring <see cref="Cell">Cells</see></returns>
        public List<Cell> GetNeighboringCells(int x, int y)
        {
            List<Cell> neighbors = new();
            for(int xOff = -1; xOff <= 1; xOff++)
            {
                for(int yOff = -1; yOff <= 1; yOff++)
                {
                    if ((xOff != 0 || yOff != 0) 
                        && (x + xOff > -1 && x + xOff < this.Width)
                        && (y + yOff > -1 && y + yOff < this.Height)) neighbors.Add(grid[x + xOff][y + yOff]);
                }
            }
            return neighbors;
        }
        
        /// <summary>
        /// Inspect whether the grid has any isolated island (a field of no-mine <see cref="Cell">Cells</see> surrounded entirely by mines.
        /// </summary>
        private void InspectGrid()
        {
            //TODO: Finish the grid inspection method
            /*
             I am currently lazy, won't start this now, but here's the idea
             Traverse through as many non-mine cells as possible
             Any non-mine cells trapped inside a bubble of mined cells should see the mines removed
             I have two choices to deal with the mine here, either relocate it or forget about its existence
             */
        }
    }
}
