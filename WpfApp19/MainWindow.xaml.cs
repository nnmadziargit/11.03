using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp19
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = ("MB7Ri");
            haslo.IsEnabled = true;

            MessageBox.Show(a);

        }

        private void bet_Click(object sender, RoutedEventArgs e)
        {
            bet.IsEnabled = true;
            MessageBox.Show($"Dane pracownika: " + imie.Text + nazwisko.Text + stanowisko.Text);
        }
    }
}