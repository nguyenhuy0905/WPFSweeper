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
        /// This is probably due to bad code habits that I have to save this dummy.
        /// Basically, the main window itself.
        /// When everything else run, mainwindow has already been created so no error should ever be thrown anyways
        /// </summary>
        public static MainWindow main;
        /// <summary>
        /// The current game
        /// </summary>
        private Game CurrentGame;
        public MainWindow()
        {
            InitializeComponent();
            main = this;
            DummyTest();
        }
    }
}
