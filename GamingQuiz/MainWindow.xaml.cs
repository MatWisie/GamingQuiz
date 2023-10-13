using GamingQuiz.Models;
using GamingQuiz.Views;
using System;
using System.Collections.Generic;
using System.Linq;
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
            WindowContent.Content = new StartScreen();
            orgQuestions = questions;
        }

        private List<QuestionModel> orgQuestions = new List<QuestionModel>();

        private List<QuestionModel> questions = new List<QuestionModel>()
        {
            new QuestionModel("Is cereal a soup", "", new AnswerModel[]
            {
                new AnswerModel(AnswersEnum.IThinkSo, new Dictionary<string,int>
                {
                    {"First Person Shooters", 10 },
                    {"RPG", 5 },
                    {"Simulators", 10 },
                    {"Strategy", 0 }
                }),
                new AnswerModel(AnswersEnum.Yes, new Dictionary<string,int>
                {
                    {"First Person Shooters", 0 },
                    {"RPG", 5 },
                    {"Simulators", 1 },
                    {"Strategy", 0 }
                }),
                new AnswerModel(AnswersEnum.No, new Dictionary<string,int>
                {
                    {"First Person Shooters", 20 },
                    {"RPG", 40 },
                    {"Simulators", 10 },
                    {"Strategy", 2 }
                }),
                new AnswerModel(AnswersEnum.IDontThinkSo, new Dictionary<string,int>
                {
                    {"First Person Shooters", 2 },
                    {"RPG", 2 },
                    {"Simulators", 3 },
                    {"Strategy", 1 }
                }),
            }),
            new QuestionModel("Is soup a cereal", "", new AnswerModel[]
            {
                new AnswerModel(AnswersEnum.IThinkSo, new Dictionary<string,int>
                {
                    {"First Person Shooters", 10 },
                    {"RPG", 5 },
                    {"Simulators", 10 },
                    {"Strategy", 0 }
                }),
                new AnswerModel(AnswersEnum.Yes, new Dictionary<string,int>
                {
                    {"First Person Shooters", 0 },
                    {"RPG", 52 },
                    {"Simulators", 10 },
                    {"Strategy", 1 }
                }),
                new AnswerModel(AnswersEnum.No, new Dictionary<string,int>
                {
                    {"First Person Shooters", 10 },
                    {"RPG", 5 },
                    {"Simulators", 10 },
                    {"Strategy", 0 }
                }),
                new AnswerModel(AnswersEnum.IDontThinkSo, new Dictionary<string,int>
                {
                    {"First Person Shooters", 22 },
                    {"RPG", 33 },
                    {"Simulators", 11 },
                    {"Strategy", 44 }
                }),
            }),
        };


        public void ChangeQuizContent()
        {
            if (questions.Count != 0)
            {
                WindowContent.Content = new Question(questions[0]);
                questions.RemoveAt(0);
            }
            else
            {
                WindowContent.Content = new SummaryScreen();
            }
        }

        public void StartNewQuiz()
        {
            if (questions.Count == 0)
                questions = orgQuestions;

            Random rnd = new Random();
            questions = questions.OrderBy(e => rnd.Next()).ToList();

            if (questions.Count != 0)
            {
                WindowContent.Content = new Question(questions[0]);
                questions.RemoveAt(0);
            }
            else
            {
                WindowContent.Content = new SummaryScreen();
            }
        }
    }
}
