using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFSweeper
{
    //some definitions to make the code less verbose
    public partial class MainWindow
    {
        public StackPanel GetRow(int row)
        {
            if(row < 0 || row >= MainStackPanel.Children.Count) throw new IndexOutOfRangeException($"Error, expected index" +
                $" from {0} to {MainStackPanel.Children.Count - 1}, got {row} instead.");
            return (StackPanel)MainStackPanel.Children[row];
        }
    }
}
