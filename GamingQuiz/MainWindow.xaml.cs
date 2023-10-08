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
                new AnswerModel(AnswersEnum.IThinkSo, new Dictionary<GenresEnum,int>
                {
                    {GenresEnum.FirstPersonShooters, 10 },
                    {GenresEnum.RPG, 5 },
                    {GenresEnum.Simulators, 10 },
                    {GenresEnum.Strategy, 0 }
                }),
                new AnswerModel(AnswersEnum.Yes, new Dictionary<GenresEnum,int>
                {
                    {GenresEnum.FirstPersonShooters, 20 },
                    {GenresEnum.RPG, 10 },
                    {GenresEnum.Simulators, 15 },
                    {GenresEnum.Strategy, 0 }
                }),
                new AnswerModel(AnswersEnum.No, new Dictionary<GenresEnum,int>
                {
                    {GenresEnum.FirstPersonShooters, 50 },
                    {GenresEnum.RPG, 60 },
                    {GenresEnum.Simulators, 5 },
                    {GenresEnum.Strategy, 1 }
                }),
                new AnswerModel(AnswersEnum.IDontThinkSo, new Dictionary<GenresEnum,int>
                {
                    {GenresEnum.FirstPersonShooters, 20 },
                    {GenresEnum.RPG, 10 },
                    {GenresEnum.Simulators, 4 },
                    {GenresEnum.Strategy, 3 }
                }),
            }),
            new QuestionModel("Is soup a cereal", "", new AnswerModel[]
            {
                new AnswerModel(AnswersEnum.IThinkSo, new Dictionary<GenresEnum,int>
                {
                    {GenresEnum.FirstPersonShooters, 10 },
                    {GenresEnum.RPG, 5 },
                    {GenresEnum.Simulators, 10 },
                    {GenresEnum.Strategy, 0 }
                }),
                new AnswerModel(AnswersEnum.Yes, new Dictionary<GenresEnum,int>
                {
                    {GenresEnum.FirstPersonShooters, 20 },
                    {GenresEnum.RPG, 10 },
                    {GenresEnum.Simulators, 15 },
                    {GenresEnum.Strategy, 0 }
                }),
                new AnswerModel(AnswersEnum.No, new Dictionary<GenresEnum,int>
                {
                    {GenresEnum.FirstPersonShooters, 50 },
                    {GenresEnum.RPG, 60 },
                    {GenresEnum.Simulators, 5 },
                    {GenresEnum.Strategy, 1 }
                }),
                new AnswerModel(AnswersEnum.IDontThinkSo, new Dictionary<GenresEnum,int>
                {
                    {GenresEnum.FirstPersonShooters, 20 },
                    {GenresEnum.RPG, 10 },
                    {GenresEnum.Simulators, 4 },
                    {GenresEnum.Strategy, 3 }
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
