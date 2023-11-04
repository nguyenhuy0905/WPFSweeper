using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WPFSweeper.Serializer
{
    public partial class GridSerializer
    {
        [JsonPropertyName("grid")]
        public int[][] Grid;
    }
}
