using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WPFSweeper
{
    public class Serializer
    {
        /// <summary>
        /// <see cref="Game">Game</see>'s difficulty
        /// </summary>
        [JsonPropertyName("difficulty")]
        public Difficulty Difficulty { get; private set; }

        /// <summary>
        /// <see cref="Game.Timer">The timer</see>
        /// </summary>
        [JsonPropertyName("time")]
        public int Timer { get; private set; }

        /// <summary>
        /// The values saved inside indicate the properties of all cells on the grid
        /// </summary>
        [JsonPropertyName("grid")]
        public int[][] Grid { get; private set; }
    }
}
