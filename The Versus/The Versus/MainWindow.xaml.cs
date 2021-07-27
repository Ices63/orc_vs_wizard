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

namespace The_Versus
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeButton(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void grabButton(object sender, RoutedEventArgs e)
        {
            this.DragMove();
        }

        private void mainGrid(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.White);
        }
    }
}
