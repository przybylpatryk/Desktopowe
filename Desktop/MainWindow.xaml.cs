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

        private void numTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            string num = numTextBox.Text;

            try
            {
                photoImage.Source = new BitmapImage(new Uri($"/src/{num}-zdjecie.jpg", UriKind.Relative));
                fingerImage.Source = new BitmapImage(new Uri($"/src/{num}-odcisk.jpg", UriKind.Relative));
            }
            catch
            {
                photoImage.Source = null;
                fingerImage.Source = null;
            }
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(firstNameTextBox.Text) && !string.IsNullOrEmpty(surnameTextBox.Text))
            {
                string eyeColor = (blueRadio.IsChecked == true) ? "niebieskie" : (greenRadio.IsChecked == true) ? "zielone" : (brownRadio.IsChecked == true) ? "piwne" : "";
                MessageBox.Show($"{firstNameTextBox.Text} {surnameTextBox.Text} kolor oczu {eyeColor}", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Wprowadź dane", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}