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

namespace XO
{
    public partial class MainWindow : Window
    {
        string currentPlayer = "X";
        int moves = 0;
        int round = 1;
        int scoreX = 0;
        int scoreO = 0;
        int draws = 0;
        bool gameOver = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.Content != null || gameOver == true)
            {
                return;
            }

            clickedButton.Content = currentPlayer;
            moves++;

            if (CheckWinner() == true)
            {
                ResultText.Text = "Wygrywa gracz " + currentPlayer;
                gameOver = true;

                if (currentPlayer == "X")
                {
                    scoreX++;
                    ScoreX.Text = scoreX.ToString();
                }
                else
                {
                    scoreO++;
                    ScoreO.Text = scoreO.ToString();
                }

                return;
            }

            if (moves == 9)
            {
                ResultText.Text = "Remis!";
                draws++;
                Draws.Text = draws.ToString();
                gameOver = true;
                return;
            }

            if (currentPlayer == "X")
            {
                currentPlayer = "O";
            }
            else
            {
                currentPlayer = "X";
            }

            PlayerText.Text = "Gracz " + currentPlayer;
        }

        private bool CheckWinner()
        {
            if (btn1.Content == btn2.Content && btn2.Content == btn3.Content && btn1.Content != null)
                return true;

            if (btn4.Content == btn5.Content && btn5.Content == btn6.Content && btn4.Content != null)
                return true;

            if (btn7.Content == btn8.Content && btn8.Content == btn9.Content && btn7.Content != null)
                return true;

            if (btn1.Content == btn4.Content && btn4.Content == btn7.Content && btn1.Content != null)
                return true;

            if (btn2.Content == btn5.Content && btn5.Content == btn8.Content && btn2.Content != null)
                return true;

            if (btn3.Content == btn6.Content && btn6.Content == btn9.Content && btn3.Content != null)
                return true;

            if (btn1.Content == btn5.Content && btn5.Content == btn9.Content && btn1.Content != null)
                return true;

            if (btn3.Content == btn5.Content && btn5.Content == btn7.Content && btn3.Content != null)
                return true;

            return false;
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            btn1.Content = null;
            btn2.Content = null;
            btn3.Content = null;
            btn4.Content = null;
            btn5.Content = null;
            btn6.Content = null;
            btn7.Content = null;
            btn8.Content = null;
            btn9.Content = null;

            currentPlayer = "X";
            moves = 0;
            gameOver = false;

            round++;
            RoundText.Text = round.ToString();

            PlayerText.Text = "Gracz X";
            ResultText.Text = "";
        }
    }
}
