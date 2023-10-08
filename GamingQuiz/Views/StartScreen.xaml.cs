using System.Windows;
using System.Windows.Controls;

namespace GamingQuiz.Views
{
    /// <summary>
    /// Interaction logic for StartScreen.xaml
    /// </summary>
    public partial class StartScreen : UserControl
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if (mainWindow != null)
            {
                mainWindow.StartNewQuiz();
            }
        }
    }
}
