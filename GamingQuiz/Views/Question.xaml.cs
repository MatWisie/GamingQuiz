using GamingQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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
            QuestionImage.Source = new BitmapImage(new Uri(question.questionImagePath, UriKind.Absolute));
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
                foreach (KeyValuePair<string, int> points in answer.PointsToCategories)
                {
                    var newvalue = (GameGenresPointsStatic.gameGenresPoints[points.Key].Item1 + points.Value, GameGenresPointsStatic.gameGenresPoints[points.Key].Item2, GameGenresPointsStatic.gameGenresPoints[points.Key].Item3);
                    GameGenresPointsStatic.gameGenresPoints[points.Key] = newvalue;
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
