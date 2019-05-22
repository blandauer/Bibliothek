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

namespace Bibliothek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Verkauf_Verleih(object sender, RoutedEventArgs e)
        {
            Lagerstand window = new Lagerstand();
            window.Show();
        }

        private void Lagerstand(object sender, RoutedEventArgs e)
        {
            VerkaufVerleih window = new VerkaufVerleih();
            window.Show();
        }

        private void Buch_Hinzufuegen(object sender, RoutedEventArgs e)
        {
            BuchHinzufuegen window = new BuchHinzufuegen();
            window.Show();
        }

    }
}
