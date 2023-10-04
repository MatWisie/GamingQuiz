using GamingQuiz.Models;
using GamingQuiz.Views;
using System.Collections.Generic;
using System.Windows;

namespace GamingQuiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<QuestionModel> questions = new List<QuestionModel>()
        {
            new QuestionModel("Is cereal a soup", "", new AnswerModel[]
            {
                new AnswerModel(new Dictionary<GenresEnum,int>
                {
                    {GenresEnum.FirstPersonShooters, 10 },
                    {GenresEnum.RPG, 5 },
                    {GenresEnum.Simulators, 10 },
                    {GenresEnum.Strategy, 0 }
                }),
            }),
        };
        public MainWindow()
        {
            InitializeComponent();
            WindowContent.Content = new Question(questions[0]);
        }
    }
}
