// Group 1 - (James Odeyale, Vanin Ferrall, Ashokchakravarthi Nagarajan)
using System.Windows;

namespace SerendipityBookSellers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        const int ZERO_BOOK_POINTS = 0;
        const int ONE_BOOK_POINTS = 5;
        const int TWO_BOOK_POINTS = 15;
        const int THREE_BOOK_POINTS = 30;
        const int FOUR_OR_MORE_BOOK_POINTS = 60;

        const int ZERO_BOOK_PURCHASE = 0;
        const int ONE_BOOK_PURCHASE = 1;
        const int TWO_BOOK_PURCHASE = 2;
        const int THREE_BOOK_PURCHASE = 3;
        const int FOUR_OR_MORE_BOOK_PURCHASE = 4;

        public MainWindow()
        {
            InitializeComponent();
            tbErrorDisplay.Visibility = Visibility.Hidden;
            spDisplayResult.Visibility = Visibility.Hidden;
        }

        private void DisplayErrorOnWrongInput(bool isShow, string message)
        {
            tbErrorDisplay.Text = message;
            tbErrorDisplay.Visibility = isShow
                ? Visibility.Visible
                : Visibility.Hidden;
        }

        private void DisplayResult(bool isShow)
        {
            spDisplayResult.Visibility = isShow
                ? Visibility.Visible
                : Visibility.Hidden;
        }

        static int EmptyStringChecker(string passedValue)
        {
            return string.IsNullOrEmpty(passedValue) ? -1 : int.Parse(passedValue);
        }

        private void CalculatePoints_Click(object sender, RoutedEventArgs e)
        {
            string enteredPoints = txtEnteredPoints.Text;

            try
            {
                DisplayErrorOnWrongInput(false, "");

                int totalPoints = EmptyStringChecker(enteredPoints);

                if (totalPoints == ZERO_BOOK_PURCHASE)
                {
                    tbPointsEarned.Text = ZERO_BOOK_POINTS.ToString();
                    DisplayResult(true);
                }
                else if (totalPoints == ONE_BOOK_PURCHASE)
                {
                    tbPointsEarned.Text = ONE_BOOK_POINTS.ToString();
                    DisplayResult(true);
                }
                else if (totalPoints == TWO_BOOK_PURCHASE)
                {
                    tbPointsEarned.Text = TWO_BOOK_POINTS.ToString();
                    DisplayResult(true);
                }
                else if (totalPoints == THREE_BOOK_PURCHASE)
                {
                    tbPointsEarned.Text = THREE_BOOK_POINTS.ToString();
                    DisplayResult(true);
                }
                else if (totalPoints >= FOUR_OR_MORE_BOOK_PURCHASE)
                {
                    tbPointsEarned.Text = FOUR_OR_MORE_BOOK_POINTS.ToString();
                    DisplayResult(true);
                }
                else
                {
                    DisplayErrorOnWrongInput(true, "Incorrect number was inputed");
                }
            }
            catch
            {
                DisplayErrorOnWrongInput(true, "Incorrect number was inputed");
                DisplayResult(false);
            }
        }

        private void Reset_Button_Click(object sender, RoutedEventArgs e)
        {
            txtEnteredPoints.Text = "";
            DisplayResult(false);
            DisplayErrorOnWrongInput(false, "");

        }

    }
}
