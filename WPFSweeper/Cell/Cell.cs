using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPFSweeper
{   //all the instance variables of the Cell class
    /// <summary>
    /// The building block of the game - the mine cells
    /// </summary>
    /// <remarks>
    /// There are three states of the cell, <see cref="IsClicked">IsClicked</see>, <see cref="HasMine">HasMine</see> and <see cref="IsFlagged">IsFlagged</see>.
    /// <list type="bullet">
    ///     <item>
    ///         <term>IsClicked</term>
    ///         <description>If <c>true</c>, the cell is an empty <c>Cell</c> that has been clicked by the player</description>
    ///     </item>
    ///     <item>
    ///         <term>HasMine</term>
    ///         <description>If <c>true</c>, the cell contains mine in it</description>
    ///     </item>
    ///     <item>
    ///         <term>IsFlagged</term>
    ///         <description>If <c>true</c>, the player has flagged the cell</description>
    ///     </item>
    /// </list>
    /// The other state, <see cref="IsChecked">IsChecked</see>, is used during the mine-distribution phase of the game.
    /// </remarks>
    public partial class Cell : Button
    {
        /// <summary>
        /// X-position on the grid
        /// </summary>
        public int X { get; private set; }

        /// <summary>
        /// Y-position on the grid
        /// </summary>
        public int Y { get; private set; }

        private bool hasMine;

        /// <summary>
        /// Whether the cell contains mine
        /// </summary>
        public bool HasMine
        {
            get { return hasMine; }
            internal set { 
                hasMine = value;
            }
        }

        private bool isFlagged;
        /// <summary>
        /// Whether the player flags this
        /// </summary>
        public bool IsFlagged
        {
            get { return isFlagged; }
            set { 
                isFlagged = value;
                if(value) this.Content = new Image()
                {
                    Source = new BitmapImage()
                    {
                        UriSource = new Uri(@"pack://application:,,,/WPFSweeper;Assets/Image/mine.png")
                    }
                };
                if (!value) this.Content = "";
                }
        }

        /// <summary>
        /// Path-finding, whether the cell has been checked
        /// </summary>
        public bool IsChecked { get; set; }

        /// <summary>
        /// Whether the cell has been clicked by the player
        /// </summary>
        private bool isClicked;

        public bool IsClicked
        {
            get { return isClicked; }
            set { 
                isClicked = value;
                if (value) this.Background = Brushes.LightGray;
            }
        }

        /// <summary>
        /// This cell's index
        /// </summary>
        public int Index { get; internal set; }

        /// <summary>
        /// The type of cell this cell is.
        /// <list type="number">
        ///     <listheader>
        ///         <term>Clicked</term>
        ///         <description>A cell that has been clicked</description>
        ///     </listheader>
        ///     <item>
        ///         <term>NormalUnflagged</term>
        ///         <description>A non-mine cell that isn't flagged</description>
        ///     </item>
        ///     <item>
        ///         <term>NormalFlagged</term>
        ///         <description>A non-mine cell that is flagged</description>
        ///     </item>
        ///     <item>
        ///         <term>MineUnflagged</term>
        ///         <description>A mine cell that isn't flagged</description>
        ///     </item>
        ///     <item>
        ///         <term>MineFlagged</term>
        ///         <description>A mine cell that is flagged</description>
        ///     </item>
        /// </list>
        /// </summary>
        public enum CellType
        {
            Clicked,
            NormalUnflagged,
            NormalFlagged,
            MineUnflagged,
            MineFlagged
        }

        //I placed these two here so that they don't get garbage-collected. 
        private static ButtonAutomationPeer? automation;
        private static IInvokeProvider? invoker;
    }
}
