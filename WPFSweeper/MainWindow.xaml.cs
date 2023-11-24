using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSweeper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Quite literally some funky MVC,
        /// In the sense that, this window instance is always created already before anything else of this program ever calls it
        /// </summary>
#pragma warning disable
        public static MainWindow window { get; internal set; }
#pragma warning restore
        /// <summary>
        /// This is useful to save the game
        /// </summary>
        public Game game { get; private set; }

        public MainWindow(Difficulty diff)
        {
            InitializeComponent();
            window = this;
            this.game = new(diff);
        }

        public MainWindow(Game game)
        {
            InitializeComponent();
            window = this;
            this.game = game;
            game.Continue();
        }

        /// <summary>
        /// Create a different game, and save if allowed to
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuNew_Click(object sender, RoutedEventArgs e)
        {
            // let's see if you want to save the game
            MessageBoxResult usrResponse = MessageBox.Show("Do you want to save this game?", "Save game?", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            switch (usrResponse)
            {
                case MessageBoxResult.Yes:
                    Serializer serializer = new Serializer();
                    serializer.Serialize();
                    break;
                case MessageBoxResult.No:
                    break;
                case MessageBoxResult.Cancel:
                    return;
            }
            GameConfigs cfg = new();
            cfg.Show();
            //the timer thread is still running at this point, so we should close it.
            game.CloseTimer();
            this.Close();
        }

        private void menuSave_Click(object sender, RoutedEventArgs e)
        {
            Serializer serializer = new();
            serializer.Serialize();
        }
    }
}
