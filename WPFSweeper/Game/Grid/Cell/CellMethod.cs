using System;
using System.Collections.Generic;
using System.Linq;
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
                private void CellFormat()
                {
                    this.Height = this.Width = 600 / (int)difficulty - 2;
                    this.BorderThickness = new System.Windows.Thickness(1);
                    this.BorderBrush = Brushes.Black;                   
                    this.Background = Brushes.SkyBlue;
                }
            }
        }
    }
}
