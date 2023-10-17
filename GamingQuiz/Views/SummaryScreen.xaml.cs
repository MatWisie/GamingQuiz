using GamingQuiz.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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

            var result = GameGenresPointsStatic.gameGenresPoints.OrderByDescending(e => e.Value.Item1).First();
            CongratzLabel.Content = $"Congratulations! Your preffered game genre is {result.Key}";
            CongratzImage.Source = new BitmapImage(new Uri(result.Value.Item3, UriKind.Absolute));
            CongratzDescription.Text = result.Value.Item2;

        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if (mainWindow != null)
            {
                foreach (var key in GameGenresPointsStatic.gameGenresPoints.Keys.ToList())
                {
                    var newvalue = (0, GameGenresPointsStatic.gameGenresPoints[key].Item2, GameGenresPointsStatic.gameGenresPoints[key].Item3);
                    GameGenresPointsStatic.gameGenresPoints[key] = newvalue;
                }
                mainWindow.StartNewQuiz();
            }
        }
    }
}
