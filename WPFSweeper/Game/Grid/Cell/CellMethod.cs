using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
                    this.Background = Brushes.Aquamarine;
                    if(this.HasMine)
                    {
                        Task.Run(() =>
                        {
                            SoundPlayer player = new(MainWindow.rootDir + @"Assets\Audio\vine_boom.wav");
                            player.Play();
                        });
                        MessageBox.Show("Skillissue");
                        return;
                    }
                    this.Content = this.Index;
                                   
                } 
                /// <summary>
                /// Guarantee and open a small no-mine area surrounding the first clicked cell
                /// </summary>
                /// <param name="x"></param>
                /// <param name="y"></param>
                private void OpenFirstArea(int x, int y)
                {
                    //TODO implement first area open
                }
            }
        }
    }
}
