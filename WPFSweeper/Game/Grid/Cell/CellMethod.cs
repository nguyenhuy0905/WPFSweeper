using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFSweeper
{
    //all methods of the Cell class excepts the constructor
    public partial class Game
    {
        public partial class Grid
        {
            private partial class Cell 
            {
                /// <summary>
                /// Format how the cell looks
                /// </summary>
                private void CellFormat()
                {
                    this.Height = this.Width = 600 / (int)difficulty - 2;
                    this.BorderThickness = new System.Windows.Thickness(1);
                    this.BorderBrush = Brushes.Black;                   
                    this.Background = Brushes.MediumAquamarine;
                }
                
                private void Cell_Click(object sender, System.Windows.RoutedEventArgs e)
                {
                    if (this.IsOpened) return;
                    using(SoundPlayer player = new())
                    {
                        this.Background = Brushes.Aquamarine;
                    //go from Cell -> Grid -> Game -> WPFSweeper -> Assets -> Audio
#pragma warning disable
                    DirectoryInfo path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.
                            GetDirectories("Assets")[0].GetDirectories("Audio")[0];
#pragma warning restore
                        if (this.hasMine)
                        {
                            player.SoundLocation = path.GetFiles("vine_boom.wav")[0].FullName;
                            player.Play();
                            return;
                        }
                        player.SoundLocation = path.GetFiles("cell_open.wav")[0].FullName;
                        player.Play();
                        this.Content = this.index;
                    }                  
                }
            }
        }
    }
}
