using System.Windows.Controls;

namespace GamingQuiz.Views
{
    /// <summary>
    /// Interaction logic for Question.xaml
    /// </summary>
    public partial class Question : UserControl
    {
        public Question(string text)
        {
            InitializeComponent();
            LabelInContent.Content = text;
        }
    }
}
