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

namespace WpfApplication13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Osoba o1 = null;
        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }
        private void PrzygotujWiazanie()
        {
            o1 = new Osoba("Jan", 20); //domyślne wartości
            GridOsoba.DataContext = o1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string tekst = String.Format("{0}{1}{2}", "Wprowadzono dane:", Environment.NewLine, o1.ToString());
            Wynik.Text = tekst;
        }

    }
}
