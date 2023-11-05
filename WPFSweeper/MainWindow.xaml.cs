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
        /// Quite literally some funky Dependency Injection,
        /// In the sense that, this window instance is always created already before anything else of this program ever calls it
        /// </summary>
#pragma warning disable
        public static MainWindow window { get; private set; }
#pragma warning restore

        public MainWindow()
        {
            InitializeComponent();
            window = this;
        }
    }
}
