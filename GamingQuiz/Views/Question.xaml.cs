using GamingQuiz.Models;
using System.Collections.Generic;
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
            if (IThinkSoButton.IsChecked == true)
            {
                foreach (AnswerModel answer in question.answers)
                {
                    foreach (KeyValuePair<GenresEnum, int> points in answer.PointsToCategories)
                    {
                        switch (points.Key)
                        {
                            case GenresEnum.Strategy:
                                GameGenresPointsStatic.Strategy += points.Value;
                                break;
                            case GenresEnum.FirstPersonShooters:
                                GameGenresPointsStatic.FirstPersonShooters += points.Value;
                                break;
                            case GenresEnum.Simulators:
                                GameGenresPointsStatic.Simulators += points.Value;
                                break;
                                // More genres here
                        }
                    }
                }
            }
        }
    }
}
