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

using System.Windows.Threading;

namespace The_Versus
{
    /// <summary>
    /// Logique d'interaction pour inGame.xaml
    /// </summary>
    public partial class inGame : Page
    {
        public inGame()
        {
            InitializeComponent();
        }

        // Les boutons du jeu //

        private void menu(object sender, RoutedEventArgs e)
        {
            Win();
        }

        private void wizAttack(object sender, RoutedEventArgs e)
        {
            if (orcHP.Width >= 10)
            {
                OrcBoum();
                orcHP.Width -= 10;
                outMana.Visibility = Visibility.Hidden;
                if (wizMP.Width <= 235)
                {
                    wizMP.Width += 10;
                }
                else if (wizMP.Width > 235)
                {
                    wizMP.Width = 245;
                }
                else { }
            }
            else
            {
                Win();
            }
        }

        private void wizSpell(object sender, RoutedEventArgs e)
        {
            if (orcHP.Width >= 20 && wizMP.Width >= 50)
            {
                orcHP.Width -= 20;
                wizMP.Width -= 50;
            }
            else if (orcHP.Width < 20 && wizMP.Width >= 50)
            {
                Win();
            }
            else
            {
                outMana.Visibility = Visibility.Visible;
            }
        }

        private void wizBlock(object sender, RoutedEventArgs e)
        {
            outMana.Visibility = Visibility.Hidden;

            if (wizHP.Width <= 230)
            {
                wizHP.Width += 15;
            }
            if (wizHP.Width > 230)
            {
                wizHP.Width = 245;
            }

            if (wizMP.Width <= 220)
            {
                wizMP.Width += 25;
            }
            if (wizMP.Width > 220)
            {
                wizMP.Width = 245;
            }

            else { }
        }



        // Les Fonctions //
        public void Win() => NavigationService.Navigate(new Uri("menu.xaml", UriKind.Relative));
        public void OrcBoum()
        {
            orcBoum.BeginInit();
            orcBoum.EndInit();
        }
    }
}
