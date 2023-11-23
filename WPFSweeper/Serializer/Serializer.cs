using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace WPFSweeper
{
    /// <summary>
    /// Saves the current game into a text file.
    /// At first I decided to save as a .json file, but, why so complicated anyways
    /// NOTE: I let total access to the text file saved. If you don't wanna break the game, please don't try to edit it
    /// </summary>
    public class Serializer
    {       
        //TODO: Implement the serializer
        private StreamWriter writer { get; set; }

        public Serializer()
        {
            // grab the directory WPFSweeper/WPFSweeper/Saves/save_[current time].txt
            string filename = Directory.GetCurrentDirectory() + $"/../../../Saves/save_1.txt";
            if(File.Exists(filename)) File.Delete(filename);
            FileStream dummy = File.Create(filename);
            dummy.Close();
            writer = new StreamWriter(filename);
        }

        public void Serialize()
        {
            //grab game info
            int timePassed = window.game.Timer;
            Difficulty difficulty = window.game.difficulty;
            Grid grid = window.game.grid;

            //write into file
            writer.WriteLine(timePassed);            
            writer.WriteLine(difficulty.ToString());

            //write cell infos into file
            for(int col = 0; col < grid.Height; col++)
            {
                string rowData = "";
                for(int row = 0; row < grid.Width; row++)
                {
                    Cell[] column = grid.grid[row];
                    rowData += $"{(int)column[col].cellType} ";
                }
                writer.WriteLine(rowData);
            }
            // guillotine the writer
            writer.Close();
            writer.Dispose();
        }
    }
}
