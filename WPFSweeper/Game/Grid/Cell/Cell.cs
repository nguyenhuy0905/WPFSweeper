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

                private int index;
                /// <summary>
                /// how many mines surround the cell. Setter only works if game hasn't started
                /// </summary>
                public int Index
                {
                    get { return index; }
                    set { if (!Game.HasStarted)
                            index = value; }
                }

                private bool hasMine;
                /// <summary>
                /// whether the cell has mine. Setter only work if game hasn't started
                /// </summary>
                public bool HasMine
                {
                    get { return hasMine; }
                    set { if(!Game.HasStarted) hasMine = value; }
                }

                /// <summary>
                /// whether the player has flagged the cell
                /// </summary>
                public bool IsFlagged { get; set; }
                /// <summary>
                /// Whether the player has clicked on the cell
                /// </summary>
                public bool IsOpened { get; private set; }
                /// <summary>
                /// Initialize the cell. Unless loading from saves, only fill in x and y
                /// </summary>
                /// <param name="x">x-position of the cell</param>
                /// <param name="y">y-position of the cell</param>
                /// <param name="index">how many mines are the cell surrounded by</param>
                /// <param name="hasMine">whether the cell contains mine</param>
                /// <param name="isFlaged">whether the player has flagged the cell</param>
                public Cell(int x, int y, int index = 0, bool hasMine = false, bool isFlagged = false, bool isOpened = false)
                {
                    //assigning stuff
                    this.X = x;
                    this.Y = y;
                    this.Index = index;
                    this.HasMine = hasMine;
                    this.IsFlagged = isFlagged;
                    this.IsOpened = isOpened;
                    this.Click += Cell_Click;
                    //format the look of the cell
                    CellFormat();
                }

                
            }
        }
    }
}
