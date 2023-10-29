using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFSweeper
{
    //all variables of the Cell class and the constructor
    public partial class Game
    {
        public partial class Grid
        {
            /// <summary>
            /// The building block of the game: the cell
            /// </summary>
            private partial class Cell : Button
            {
                /// <summary>
                /// x-position of the cell
                /// </summary>
                public int X { get; protected set; }
                /// <summary>
                /// y-position of the cell
                /// </summary>
                public int Y { get; protected set; }
                /// <summary>
                /// how many mines surround the cell
                /// </summary>
                public int Index { get; protected set; }
                /// <summary>
                /// whether the cell has mine
                /// </summary>
                public bool hasMine { get; protected set; }
                /// <summary>
                /// whether the player has flagged the cell
                /// </summary>
                public bool isFlagged { get; set; }
                /// <summary>
                /// Initialize the cell. Unless loading from saves, only x and y are required
                /// </summary>
                /// <param name="x">x-position of the cell</param>
                /// <param name="y">y-position of the cell</param>
                /// <param name="index">how many mines are the cell surrounded by</param>
                /// <param name="hasMine">whether the cell contains mine</param>
                /// <param name="isFlaged">whether the player has flagged the cell</param>
                public Cell(int x, int y, int index = 0, bool hasMine = false, bool isFlagged = false)
                {
                    //assigning stuff
                    this.X = x;
                    this.Y = y;
                    this.Index = index;
                    this.hasMine = hasMine;
                    this.isFlagged = isFlagged;
                    //format the look of the cell
                    CellFormat();
                }
            }
        }
    }
}
