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

namespace Desktop
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

        private void Button_Click_Check(object sender, RoutedEventArgs e)
        {
            if (RadioPoczt.IsChecked == true)
            {
                Img.Source = new BitmapImage(new Uri("/src/pocztowka.png", UriKind.Relative));
                Price.Text = "Cena: 1 zł";
            }
            if (RadioList.IsChecked == true)
            {
                Img.Source = new BitmapImage(new Uri("/src/list.png", UriKind.Relative));
                Price.Text = "Cena: 1,5 zł";
            }
            if (RadioPaczk.IsChecked == true)
            {
                Img.Source = new BitmapImage(new Uri("/src/paczka.png", UriKind.Relative));
                Price.Text = "Cena: 10 zł";
            }
        }

        private void Button_Click_Confirm(object sender, RoutedEventArgs e)
        {
            string ZipCode = Zip.Text;
            string digits = "0123456789";

            if (ZipCode.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            for (int i = 0; i < ZipCode.Length; i++)
            {
                if (!digits.Contains(ZipCode[i]))
                {
                    MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }

            MessageBox.Show("Dane przesyłki zostały wprowadzone", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}