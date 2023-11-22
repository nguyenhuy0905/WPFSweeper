using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSweeper
{
    //contains all instance variable of the grid
    /// <summary>
    /// A container containing all the <see cref="Cell">Cell</see>s
    /// </summary>
    /// <remarks>
    /// The creation of <c>Grid</c> depends on whether the <see cref="Game">Game</see> is new or is loaded from save. 
    /// If an entirely new game is loaded, the grid will also distribute mines then scan for any isolated area. If such
    /// area exists, some of the mines causing the isolation will be redistributed
    /// </remarks>
    public partial class Grid
    {
        /// <summary>
        /// The <see cref="Grid">Grid</see> itself
        /// </summary>
        public Cell[][] grid { get; private set; }

        /// <summary>
        /// Width of the <see cref="Grid">Grid</see>. Equals 1.6 * Height
        /// </summary>
        public int Width { get; private set; }

        /// <summary>
        /// Height of the <see cref="Grid">Grid</see>
        /// </summary>
        public int Height { get; private set; }

        /// <summary>
        /// How many mines there are in the <see cref="Grid">Grid</see>
        /// </summary>
        public int NumMine { get; private set; }
    }
}
