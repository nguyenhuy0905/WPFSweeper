using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSweeper
{
    internal class Deserializer
    {
        private StreamReader reader { get; set; }

        public Deserializer() 
        {
            // dummy placed here. Maybe the test project should not have existed
            reader = new StreamReader($"{Directory.GetCurrentDirectory()}/../../../Saves/save_1.txt");
        }

        public void Deserialize()
        {
#pragma warning disable
            // ReadLine is 100% not null here, unless you somehow disobey me and play with the save text file, which a null reference exception is probably thrown at you
            // start deserialization
            int timer = int.Parse(reader.ReadLine());
            Difficulty difficulty;
            Enum.TryParse(reader.ReadLine(), out difficulty);
#pragma warning restore
            // reading grid data
            string? rowData = reader.ReadLine();
            Cell[][] cells = new Cell[(int)difficulty * 8 / 5][];
            int r = 0;
            while(rowData is not null)
            {
                string[] cellState = rowData.Split(' ');
                cells[r] = new Cell[(int)difficulty];
                if (cellState.Length != cells[r].Length) throw new Exception("Error, saved file either corrupted or has been modified");
                for(int i = 0; i < cells[r].Length; i++)
                {
                    Enum.TryParse(cellState[i], out CellType type);
                    cells[r][i] = new Cell(r, i, 960 /((int) difficulty * 8 / 5) - 2, type); 
                }
                r++;
                rowData = reader.ReadLine();
            }
            // create a new game and start
        }
    }
}
