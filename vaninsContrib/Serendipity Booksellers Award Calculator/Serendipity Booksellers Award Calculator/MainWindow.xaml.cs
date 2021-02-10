// Vanin Ferrall - Group 1
using System.Collections.Generic;
// using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Serendipity_Booksellers_Award_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, decimal> MONTHLY_POINTS = new Dictionary<string, decimal>()
            {
                {"January", 0 },
                {"February", 0 },
                {"March", 0 },
                {"April", 0 },
                {"May", 0 },
                {"June", 0 },
                {"July", 0 },
                {"August", 0 },
                {"September", 0 },
                {"October", 0 },
                {"November", 0 },
                {"December", 0 }
            };

        Dictionary<string, decimal> POINTS_AWARDED = new Dictionary<string, decimal>()
            {
                {"0", 0 },
                {"1", 5 },
                {"2", 15 },
                {"3", 30 },
                {"4+", 60 }
            };

        const decimal AMAZING_POINTS_THRESHOLD = 60;
        const decimal MONTHLY_ON_A_ROLL_THRESHOLD = 15;

        public MainWindow()
        {
            InitializeComponent();

            foreach (string month in MONTHLY_POINTS.Keys)
            {
                MonthInput.Items.Add(month);
            }

            foreach (string points in POINTS_AWARDED.Keys)
            {
                BookInput.Items.Add(points);
            }
        }

        private void Update_Data()
        {
            string monthInputKey = MonthInput.SelectedItem.ToString();
            // I like lambda in Python, and I thought about it in c# and found LINQ
            // decimal totalPoints = monthlyPoints.Sum(x => x.Value);
            decimal totalPoints = 0;
            foreach (decimal i in MONTHLY_POINTS.Values)
            {
                totalPoints += i;
            }

            Total.Text = (totalPoints > AMAZING_POINTS_THRESHOLD) ?
                $"You've earned {totalPoints} points so far this year! Amazing!" :
                $"You've earned {totalPoints} points so far this year.";

            CurrentMonthlyPoints.Text = (MONTHLY_POINTS[monthInputKey] > MONTHLY_ON_A_ROLL_THRESHOLD && totalPoints > AMAZING_POINTS_THRESHOLD) ?
                $"You currently have {MONTHLY_POINTS[monthInputKey]} points this month! You are on a roll!" :
                $"You currently have {MONTHLY_POINTS[monthInputKey]} points this month";
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            MONTHLY_POINTS[MonthInput.SelectedItem.ToString()] = POINTS_AWARDED[BookInput.SelectedItem.ToString()];
            Update_Data();
        }

        private void MonthInput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update_Data();
        }
    }
}
