using GamingQuiz.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace GamingQuiz.Views
{
    /// <summary>
    /// Interaction logic for SummaryScreen.xaml
    /// </summary>
    public partial class SummaryScreen : UserControl
    {
        string result;
        public SummaryScreen()
        {
            InitializeComponent();

            result = GameGenresPointsStatic.gameGenresPoints.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            CongratzLabel.Content = $"Congratulations! Your preffered game genre is {result}";

            switch (result)
            {
                case "Strategy":
                    CongratzDescription.Text = "You love thinking etc";
                    break;
                case "First Person Shooters":
                    CongratzDescription.Text = "You love shooting etc";
                    break;
                case "Simulators":
                    CongratzDescription.Text = "You love working in gaming wow etc";
                    break;
            }

        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if (mainWindow != null)
            {
                mainWindow.StartNewQuiz();
            }
        }
    }
}
