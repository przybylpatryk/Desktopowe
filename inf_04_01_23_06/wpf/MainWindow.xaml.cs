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

namespace wpf
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

        private void btnPrzelicz_Click(object sender, RoutedEventArgs e)
        {
            float zl = float.Parse(txtZlotowki.Text);
            if (rbEuro.IsChecked == true)
            {
                float euro = zl / 4.5f;
                txtWynik.Text = $"{euro:F2} EUR";
            }
            else if (rbDolar.IsChecked == true)
            {
                float dolar = zl / 4.0f;
                txtWynik.Text = $"{dolar:F2} USD";
            }
            else if (rbFunt.IsChecked == true)
            {
                float funt = zl / 5.0f;
                txtWynik.Text = $"{funt:F2} GBP";
            }
        }
    }
}