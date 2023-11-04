using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSweeper
{
    public partial class Game
    {
        /// <summary>
        /// Skillissue counter
        /// </summary>
        public int Timer { get; private set; }
        
        /// <summary>
        /// Some difficulty selection. The values represent the height of the grid
        /// <list type="bullet">
        ///     <listheader>
        ///         <term>Easy</term>
        ///         <description>16x10 grid</description>
        ///     </listheader>
        ///     <item>
        ///         <term>Medium</term>
        ///         <description>24x15 grid</description>
        ///     </item>
        ///     <item>
        ///         <term>Hard</term>
        ///         <description>32x20 grid</description>
        ///     </item>
        /// </list>
        /// </summary>
        public enum Difficulty
        {
            Easy = 10,
            Medium = 15,
            Hard = 20
        }

    }
}
