using GamingQuiz.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
namespace GamingQuiz.Views
{
    /// <summary>
    /// Interaction logic for Question.xaml
    /// </summary>
    public partial class Question : UserControl
    {
        private QuestionModel question;
        public Question(QuestionModel question)
        {
            InitializeComponent();
            this.question = question;
            QuestionTextBlock.Text = question.questionText;
        }

        private AnswersEnum selectedAnswer;
        private void AnswerClick(object sender, System.Windows.RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                selectedAnswer = (AnswersEnum)radioButton.CommandParameter;
                NextQuestionButton.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void NextQuestionButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            if (question.answers != null)
            {
                AnswerModel answer = question.answers.FirstOrDefault(e => e.Name == selectedAnswer);
                foreach (KeyValuePair<GenresEnum, int> points in answer.PointsToCategories)
                {
                    switch (points.Key)
                    {
                        case GenresEnum.Strategy:
                            GameGenresPointsStatic.gameGenresPoints["Strategy"] += points.Value;
                            break;
                        case GenresEnum.FirstPersonShooters:
                            GameGenresPointsStatic.gameGenresPoints["First Person Shooters"] += points.Value;
                            break;
                        case GenresEnum.Simulators:
                            GameGenresPointsStatic.gameGenresPoints["Simulators"] += points.Value;
                            break;
                            // More genres here
                    }
                }

            }
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if (mainWindow != null)
            {
                mainWindow.ChangeQuizContent();
            }
        }
    }
}
