using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
using System.Windows.Shapes;

namespace WPFSweeper
{
    /// <summary>
    /// Interaction logic for GameConfigs.xaml
    /// </summary>
    public partial class GameConfigs : Window
    {
        public GameConfigs()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fires when btnQuit is clicked
        /// </summary>
        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to close this window?", "Closing", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                return;             
            }
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Fires when btnNewGame is clicked
        /// </summary>
        private void StartNewGame(object sender, RoutedEventArgs e)
        {
            Difficulty diff = new();
            switch(cmbDifficulty.SelectedIndex)
            {
                case 0:
                    diff = Difficulty.Easy;
                    break;
                case 1:
                    diff = Difficulty.Medium;
                    break;
                case 2:
                    diff = Difficulty.Hard;
                    break;
            }
            window = new MainWindow(diff);
            window.Show();
            this.Close();
        }

        /// <summary>
        /// Fires when btnLoadSave is clicked.
        /// </summary>
        private void LoadSavedGame(object sender, RoutedEventArgs e)
        {
            //TODO: Implement save method
            string dir = Directory.GetCurrentDirectory();
            OpenFileDialog ofd = new()
            {
                InitialDirectory = dir,
            };
            var dialogResult = ofd.ShowDialog();
            if (dialogResult == true)
            {
                string path = ofd.FileName;
                Deserializer deserializer = new(path);
                deserializer.Deserialize();
                this.Close();
            }
            
        }
    }
}
