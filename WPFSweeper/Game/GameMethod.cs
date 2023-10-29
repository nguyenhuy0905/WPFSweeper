using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSweeper
{
    //all the methods except the constructor is stored here
    public partial class Game
    {
        /// <summary>
        /// Update the clock
        /// </summary>
        /// <param name="sender">the timer</param>
        /// <param name="e">event argument</param>
        private void UpdateClock(object sender, EventArgs e)
        {
            int currentTime = int.Parse(MainWindow.main.TimerClock.Text);
            currentTime++;
            MainWindow.main.TimerClock.Text = currentTime.ToString();
        }
    }
}
