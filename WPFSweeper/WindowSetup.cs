using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFSweeper
{
    public partial class MainWindow
    {
        /// <summary>
        /// Test plugin before I deploy the whole thing
        /// </summary>
        private void DummyTest()
        {
            Game.Difficulty difficulty = Game.Difficulty.Hard;
            LoadStackPanels((int)difficulty);
            Game testGame = new(difficulty);
            this.CurrentGame = testGame;           
        }
        /// <summary>
        /// Load horizontal stack panels.
        /// </summary>
        /// <param name="numPanels">The amount of stack panels to load</param>
        private void LoadStackPanels(int numPanels)
        {
            for(int i = 0; i < numPanels; i++)
            {
                StackPanel sp = new();
                //setting properties
                sp.Name = $"Row_{i}";
                sp.Orientation = Orientation.Horizontal;

                //adding to the main stackpanel
                MainStackPanel.Children.Add(sp);
            }
        }
        
        
    }
}
