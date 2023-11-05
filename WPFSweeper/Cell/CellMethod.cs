using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace WPFSweeper
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
        public Cell(int x, int y, CellType type = CellType.NormalUnflagged)
        {
            //assigning instance values and the Click event
            this.X = x;
            this.Y = y;
            SetProperties(type);
            this.IsChecked = false;
            this.MouseRightButtonUp += Cell_RightClick;
            this.MouseLeftButtonUp += Cell_LeftClick;            
            //Cell appreance is modified in GridMethod, since some of its appearance properties depend on the size of the grid          
        }
        /// <summary>
        /// Change cell properties and appearance (excluding the cell's dimension)
        /// </summary>
        /// <param name="type">the cell type</param>
        private void SetProperties(CellType type)
        {
            //Normal cell
            this.IsFlagged = false;
            this.HasMine = false;
            //other types
            switch(type)
            {
                case CellType.Clicked:
                    this.IsClicked = true;
                    this.Background = Brushes.Aqua;
                    break;
                case CellType.MineUnflagged:
                    this.HasMine = true;
                    this.Background = Brushes.Aquamarine;
                    break;
                case CellType.MineFlagged:
                    this.IsFlagged = true;
                    goto case CellType.MineUnflagged;
                case CellType.NormalFlagged:
                    this.IsFlagged = true;
                    this.Background= Brushes.Aquamarine;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Left click event of the <c>Cell</c>
        /// </summary>
        /// <param name="sender">The <c>Cell</c> itself</param>
        /// <param name="e"><see cref="MouseButtonEventArgs">Event Argument</see></param>
        private void Cell_LeftClick(object sender, MouseButtonEventArgs e)
        {
            /*
             TODO: Implement LeftClick event to the cell.
             The LeftClick event has a few cases:
             If the game has yet to start (or, this is the first cell to be clicked), the grid should start distributing mines,
             and mark some of this cell's neighbors as mine-free.
             If the cell is flagged, do nothing.
             If the cell is mined, show all other mines and a fail message.
             Else, open the cell. If the cell's index is 0, open up its neighbors as well.
             */
        }

        /// <summary>
        /// Right click event of the <c>Cell</c>
        /// </summary>
        /// <param name="sender">The <c>Cell</c> itself</param>
        /// <param name="e"><see cref="MouseButtonEventArgs">Event Argument</see></param>
        private void Cell_RightClick(object sender, MouseButtonEventArgs e)
        {
            /*
             * TODO: Implement RightClick event to the cell
             * Right click has 2 cases:
             * If the cell is flagged, remove the flag
             * Otherwise, flag the cell
             */
        }
    }
}
