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

namespace WpfApplication11
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

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            // ... lista
            List<string> data = new List<string>();
            data.Add("Book");
            data.Add("Computer");
            data.Add("Chair");
            data.Add("Mug");
            // ... ustawienie referencji
            var comboBox = sender as ComboBox;
            // ... ustawienie zródla
            comboBox.ItemsSource = data;
            // ... czy cos domyslnie ma byc wybrane
            comboBox.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... dostep do combo.
            var comboBox = sender as ComboBox;
            // ... ustawiemy wybraną opcję jako tytul okna
            string value = comboBox.SelectedItem as string;
            this.Title = "Selected: " + value; 
        }
    }
}
