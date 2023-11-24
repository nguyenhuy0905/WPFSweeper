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

        public Deserializer(string path) 
        {
            // dummy placed here. Maybe the test project should not have existed
            reader = new StreamReader(path);
        }

        public MainWindow Deserialize()
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
            // fill up the grid
            Cell[][] cells = new Cell[(int)difficulty * 8 / 5][];
            for(int i = 0; i < cells.Length; i++)
            {
                cells[i] = new Cell[(int)difficulty];
            }
            int c = 0;
            while(rowData is not null)
            {
                string[] cellState = rowData.Split(' ');
                // to avoid the space at the end of each save file, which caused the last digit of cellstate to be ""
                if (cellState.Length - 1 != cells.Length) throw new Exception("Something wrong (about the save file), I can feel it");
                CellType type;
                for(int x = 0; x < cellState.Length - 1; x++)
                {
                    Enum.TryParse(cellState[x], out type);
                    cells[x][c] = new Cell(x, c, 960 / ((int)difficulty * 8 / 5) - 2, type);
                }
                c++;
                rowData = reader.ReadLine();
            }
            
            // create a new game and start
            reader.Dispose();
            reader.Close();
            window = new MainWindow(new Game(difficulty, cells, timer));
            window.Show();
            return window;
        }
    }
}
