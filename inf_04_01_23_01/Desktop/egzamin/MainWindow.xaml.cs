using System.Data;
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

namespace egzamin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string finalPassword = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            finalPassword = "";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            string specialChars = "!@#$%^&*()_+-=";

            int passwordLength = int.Parse(txtLength.Text);

            Random random = new Random();

            if (cbUpperLower.IsChecked == true)
            {
                finalPassword += upperCase[random.Next(upperCase.Length)];
            }

            if (cbNums.IsChecked == true)
            {
                finalPassword += numbers[random.Next(numbers.Length)];
            }

            if (cbChars.IsChecked == true)
            {
                finalPassword += specialChars[random.Next(specialChars.Length)];
            }

            while (finalPassword.Length < passwordLength)
            {

                finalPassword += lowerCase[random.Next(lowerCase.Length)];
            }

            MessageBox.Show(finalPassword);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            ComboBoxItem cbItem = (ComboBoxItem)cbBox.SelectedItem;
            string position = cbItem.Content.ToString();

            MessageBox.Show($"Dane pracownika: {name} {surname} {position} Hasło: {finalPassword}");
        }
    }
}