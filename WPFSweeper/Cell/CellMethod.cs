using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSweeper.Cell
{
    //constructor and methods of the Cell class
    public partial class Cell
    {
        /// <summary>
        /// Constructor of the Cell class. If loading a new game, only x and y should be filled
        /// </summary>
        /// <param name="x">x-position of the cell</param>
        /// <param name="y">y-position of the cell</param>
        /// <param name="hasMine">whether the cell has mine</param>
        /// <param name="isFlagged">whether the player has flagged the cell</param>
        /// <param name="isClicked">whether the player has clicked the cell</param>
        public Cell(int x, int y, bool hasMine = false, bool isFlagged = false, bool isClicked = false)
        {
            //assigning instance values and the Click event
            this.X = x;
            this.Y = y;
            this.HasMine = hasMine;
            this.IsFlagged = isFlagged;
            this.IsClicked = isClicked;
            this.IsChecked = false;
            this.Click += Cell_Click;
            //modify the cell's appearance
            //TODO: Add some appearances to the cell
        }

        /// <summary>
        /// In case the cell gets clicked
        /// </summary>
        /// <param name="sender">The cell itself</param>
        /// <param name="e">A delegate basically</param>
        private void Cell_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //TODO: Implement Click method
        }
    }
}
