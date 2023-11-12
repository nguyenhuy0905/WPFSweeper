using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSweeper
{
    /// <summary>
    /// The <see cref="Game">Game</see> is the entry point of the program. 
    /// </summary>
    /// <remarks>
    /// Whenever the user runs the program, a new instance of Game (and consequently, <see cref="Grid">Grid</see> and all its <see cref="Cell">Cell</see>s) 
    /// are created. The size of the <c>Grid</c> depends on the <see cref="Difficulty">Difficulty</see> passed in by the user. 
    /// </remarks>
    public partial class Game
    {
        /// <summary>
        /// Skillissue counter
        /// </summary>
        public int Timer { get; private set; }
        
        /// <summary>
        /// Some difficulty selection. The values represent the <see cref="Grid.Height">Height</see> of the <see cref="Grid">Grid</see>.
        /// <list type="bullet">
        ///     <listheader>
        ///         <term>Easy</term>
        ///         <description>16x10 <c>Grid</c></description>
        ///     </listheader>
        ///     <item>
        ///         <term>Medium</term>
        ///         <description>24x15 <c>Grid</c></description>
        ///     </item>
        ///     <item>
        ///         <term>Hard</term>
        ///         <description>32x20 <c>Grid</c></description>
        ///     </item>
        /// </list>
        /// </summary>
        public enum Difficulty
        {
            Easy = 10,
            Medium = 15,
            Hard = 20
        }

        /// <summary>
        /// The <see cref="Grid">Grid</see> container. I don't have so much experience in MVVM/MVC or Dependency Injection, so this
        /// is how I deal with such stuff.
        /// </summary>
        public static Grid grid { get; set; }
    }
}
