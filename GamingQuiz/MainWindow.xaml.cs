using GamingQuiz.Views;
using System.Windows;

namespace GamingQuiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowContent.Content = new Question("im a question!!!");
        }
    }
}
