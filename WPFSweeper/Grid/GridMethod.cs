using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.Width = (int)difficulty * 8/5;
            this.Height = (int)difficulty;
            this.NumMine = Width * Height / 4;
        }

        /// <summary>
        /// Start adding mines to the <see cref="Grid">Grid</see>
        /// </summary>
        private void AddMines()
        {
            //TODO: Use the RNG to distribute mines
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
            //TODO: Add all neighbors into the list

            return neighbors;
        }
        
        /// <summary>
        /// Inspect whether the grid has any isolated island (a field of no-mine <see cref="Cell">Cells</see> surrounded entirely by mines.
        /// 
        /// </summary>
        private void InspectGrid()
        {
            //TODO: Finish the grid inspection method
        }
    }
}
