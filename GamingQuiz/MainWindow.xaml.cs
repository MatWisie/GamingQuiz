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
            new QuestionModel("Do you like being the leader", "https://d19d5sz0wkl0lu.cloudfront.net/dims4/default/c5dc383/2147483647/resize/800x%3E/quality/90/?url=https%3A%2F%2Fatd-brightspot.s3.amazonaws.com%2F082316-leadership.jpg", new AnswerModel[]
            {
                new AnswerModel(AnswersEnum.IThinkSo, new Dictionary<string,int>
                {
                    {"Strategy", 5 },
                }),
                new AnswerModel(AnswersEnum.Yes, new Dictionary<string,int>
                {
                    {"Strategy", 10 },
                    {"Role-Playing", 5 }
                }),
                new AnswerModel(AnswersEnum.No, new Dictionary<string,int>
                {
                    {"Fighting", 2 },
                    {"Puzzle", 2 },
                    {"Adventure", 2 },
                }),
                new AnswerModel(AnswersEnum.IDontThinkSo, new Dictionary<string,int>
                {
                    {"Fighting", 2 }
                }),
            }),
            new QuestionModel("Do you like to make decisions quickly", "https://bmmagazine.co.uk/wp-content/uploads/2012/10/decisionmakingskills.jpg", new AnswerModel[]
            {
                new AnswerModel(AnswersEnum.IThinkSo, new Dictionary<string,int>
                {
                    {"Action", 5 },
                    {"Shooter", 5 }
                }),
                new AnswerModel(AnswersEnum.Yes, new Dictionary<string,int>
                {
                    {"Action", 10 },
                    {"Shooter", 10 },
                    {"Racing", 5 }
                }),
                new AnswerModel(AnswersEnum.No, new Dictionary<string,int>
                {
                    {"Strategy", 5 },
                    {"Puzzle", 10 },
                    {"Adventure", 5 },

                }),
                new AnswerModel(AnswersEnum.IDontThinkSo, new Dictionary<string,int>
                {
                    {"Strategy", 2 },
                    {"Puzzle", 5 },
                    {"Adventure", 2 },
                }),
            }),
            new QuestionModel("Do you like fast-paced action", "https://i0.wp.com/thetechhacker.com/wp-content/uploads/2017/06/Best-Action-Games-for-PC.jpg?fit=1366%2C768&ssl=1", new AnswerModel[]
            {
                new AnswerModel(AnswersEnum.IThinkSo, new Dictionary<string,int>
                {
                    {"Action", 5 },
                    {"Shooter", 5 },
                    {"Racing", 5 }
                }),
                new AnswerModel(AnswersEnum.Yes, new Dictionary<string,int>
                {
                    {"Action", 10 },
                    {"Shooter", 10 },
                    {"Racing", 10 }
                }),
                new AnswerModel(AnswersEnum.No, new Dictionary<string,int>
                {
                    {"Strategy", 5 },
                    {"Puzzle", 10 },
                    {"Adventure", 5 },
                    {"Simulation", 5 },

                }),
                new AnswerModel(AnswersEnum.IDontThinkSo, new Dictionary<string,int>
                {
                    {"Strategy", 2 },
                    {"Puzzle", 5 },
                    {"Adventure", 2 },
                    {"Simulation", 2 },
                }),
            }),
            new QuestionModel("Do you like having to use your reflexes to come out on top", "https://prod.assets.earlygamecdn.com/images/awp-aim.png?transform=article_webp&x=0.5&y=0.5", new AnswerModel[]
            {
                new AnswerModel(AnswersEnum.IThinkSo, new Dictionary<string,int>
                {
                    {"Action", 5 },
                    {"Shooter", 5 },
                    {"Racing", 5 },
                    {"Fighting", 5 }
                }),
                new AnswerModel(AnswersEnum.Yes, new Dictionary<string,int>
                {
                    {"Action", 10 },
                    {"Shooter", 10 },
                    {"Racing", 10 },
                    {"Fighting", 10 }
                }),
                new AnswerModel(AnswersEnum.No, new Dictionary<string,int>
                {
                    {"Strategy", 5 },
                    {"Puzzle", 10 },
                    {"Adventure", 5 },
                    {"Simulation", 5 },
                    {"Role-Playing", 10 },

                }),
                new AnswerModel(AnswersEnum.IDontThinkSo, new Dictionary<string,int>
                {
                    {"Strategy", 2 },
                    {"Puzzle", 5 },
                    {"Adventure", 2 },
                    {"Simulation", 2 },
                    {"Role-Playing", 5 },
                }),
            }),
            new QuestionModel("Do you enjoy being immersed in the game's world", "https://cdn3.whatculture.com/images/2016/11/e7e270241a7e7398-1200x675.jpg", new AnswerModel[]
            {
                new AnswerModel(AnswersEnum.IThinkSo, new Dictionary<string,int>
                {
                    {"Role-Playing", 10 },
                    {"Simulation", 5 },
                    {"Adventure", 2 },
                }),
                new AnswerModel(AnswersEnum.Yes, new Dictionary<string,int>
                {
                    {"Role-Playing", 15 },
                    {"Simulation", 10 },
                    {"Adventure", 5 },
                }),
                new AnswerModel(AnswersEnum.No, new Dictionary<string,int>
                {
                    {"Racing", 10 },
                    {"Fighting", 10 }

                }),
                new AnswerModel(AnswersEnum.IDontThinkSo, new Dictionary<string,int>
                {
                    {"Racing", 5 },
                    {"Fighting", 5 }
                }),
            }),
            new QuestionModel("Do you like good stories", "https://i.redd.it/35olgv0d5q901.png", new AnswerModel[]
            {
                new AnswerModel(AnswersEnum.IThinkSo, new Dictionary<string,int>
                {
                    {"Role-Playing", 10 },
                    {"Adventure", 2 },
                }),
                new AnswerModel(AnswersEnum.Yes, new Dictionary<string,int>
                {
                    {"Role-Playing", 15 },
                    {"Adventure", 5 },
                }),
                new AnswerModel(AnswersEnum.No, new Dictionary<string,int>
                {
                    {"Racing", 10 },
                    {"Fighting", 10 },
                    {"Action", 5 },
                    {"Platformers", 5 }

                }),
                new AnswerModel(AnswersEnum.IDontThinkSo, new Dictionary<string,int>
                {
                    {"Racing", 5 },
                    {"Fighting", 5 },
                    {"Action", 2 },
                    {"Platformers", 2 }
                }),
            }),
            new QuestionModel("Are you competetive", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/96/LGD_Gaming_at_the_2015_LPL_Summer_Finals.jpg/1200px-LGD_Gaming_at_the_2015_LPL_Summer_Finals.jpg", new AnswerModel[]
            {
                new AnswerModel(AnswersEnum.IThinkSo, new Dictionary<string,int>
                {
                    {"Shooter", 5 },
                    {"Racing", 5 },
                    {"Fighting", 5 },
                    {"Strategy", 2 },
                }),
                new AnswerModel(AnswersEnum.Yes, new Dictionary<string,int>
                {
                    {"Shooter", 10 },
                    {"Racing", 10 },
                    {"Fighting", 10 },
                    {"Strategy", 5 },
                }),
                new AnswerModel(AnswersEnum.No, new Dictionary<string,int>
                {
                    {"Adventure", 10 },
                    {"Platformers", 15 },
                    {"Puzzle", 15 },
                    {"Role-Playing", 10 },
                    {"Simulation", 10 }

                }),
                new AnswerModel(AnswersEnum.IDontThinkSo, new Dictionary<string,int>
                {
                    {"Adventure", 5 },
                    {"Platformers", 10 },
                    {"Puzzle", 10 },
                    {"Role-Playing", 5 },
                    {"Simulation", 5 }
                }),
            }),
            new QuestionModel("Do you enjoy solving puzzles", "https://robertheaton.com/images/the-witness-puzzle.jpg", new AnswerModel[]
            {
                new AnswerModel(AnswersEnum.IThinkSo, new Dictionary<string,int>
                {
                    {"Puzzle", 10 },
                    {"Adventure", 5 },
                }),
                new AnswerModel(AnswersEnum.Yes, new Dictionary<string,int>
                {
                    {"Puzzle", 15 },
                    {"Adventure", 10 },
                }),
                new AnswerModel(AnswersEnum.No, new Dictionary<string,int>
                {
                    {"Simulation", 10 },
                    {"Shooter", 10 },
                    {"Racing", 10 },
                    {"Action", 10 },
                }),
                new AnswerModel(AnswersEnum.IDontThinkSo, new Dictionary<string,int>
                {
                    {"Simulation", 5 },
                    {"Shooter", 5 },
                    {"Racing", 5 },
                    {"Action", 5 },
                }),
            }),
            new QuestionModel("Do you enjoy exploring new environments", "https://cdn.mos.cms.futurecdn.net/GTvQDMxXZ89cgMShEMETGg.jpg", new AnswerModel[]
            {
                new AnswerModel(AnswersEnum.IThinkSo, new Dictionary<string,int>
                {
                    {"Role-Playing", 10 },
                    {"Adventure", 5 },
                }),
                new AnswerModel(AnswersEnum.Yes, new Dictionary<string,int>
                {
                    {"Role-Playing", 15 },
                    {"Adventure", 5 },
                }),
                new AnswerModel(AnswersEnum.No, new Dictionary<string,int>
                {
                    {"Shooter", 5 },
                    {"Racing", 5 },
                    {"Fighting", 5 },
                }),
                new AnswerModel(AnswersEnum.IDontThinkSo, new Dictionary<string,int>
                {
                    {"Shooter", 2 },
                    {"Racing", 2 },
                    {"Fighting", 2 },
                }),
            }),
            new QuestionModel("Do you enjoy dueling", "https://www.ox.ac.uk/sites/files/oxford/styles/ow_medium_feature/s3/field/field_image_main/duel.jpg?itok=SkBQyptU", new AnswerModel[]
            {
                new AnswerModel(AnswersEnum.IThinkSo, new Dictionary<string,int>
                {
                    {"Fighting", 10 },
                    {"Racing", 2 },
                    {"Shooter", 2 },
                }),
                new AnswerModel(AnswersEnum.Yes, new Dictionary<string,int>
                {
                    {"Fighting", 15 },
                    {"Racing", 5 },
                    {"Shooter", 5 },
                }),
                new AnswerModel(AnswersEnum.No, new Dictionary<string,int>
                {
                    {"Puzzle", 10 },
                    {"Simulation", 10 },
                    {"Adventure", 5 },
                    {"Platformers", 5 },
                }),
                new AnswerModel(AnswersEnum.IDontThinkSo, new Dictionary<string,int>
                {
                    {"Puzzle", 5 },
                    {"Simulation", 5 },
                    {"Adventure", 2 },
                    {"Platformers", 2 },
                }),
            }),
            new QuestionModel("Do you enjoy figuring out complex mechanics", "https://images.squarespace-cdn.com/content/v1/55ff0e9ce4b0f86318ea24b4/1442782962399-07XSOU4W7IRBB432M6DR/inide-of-watches-beautiful-and-complex-mechanisms-7.jpg", new AnswerModel[]
            {
                new AnswerModel(AnswersEnum.IThinkSo, new Dictionary<string,int>
                {
                    {"Simulation", 10 },
                    {"Fighting", 5 },
                    {"Strategy", 10 },
                }),
                new AnswerModel(AnswersEnum.Yes, new Dictionary<string,int>
                {
                    {"Simulation", 15 },
                    {"Fighting", 10 },
                    {"Strategy", 15 },
                }),
                new AnswerModel(AnswersEnum.No, new Dictionary<string,int>
                {
                    {"Action", 10 },
                    {"Adventure", 10 },
                    {"Platformers", 10 },
                    {"Shooter", 10 },
                }),
                new AnswerModel(AnswersEnum.IDontThinkSo, new Dictionary<string,int>
                {
                    {"Action", 5 },
                    {"Adventure", 5 },
                    {"Platformers", 5 },
                    {"Shooter", 5 },
                }),
            }),
            new QuestionModel("Are you interested in building and managing your own empires or cities", "https://m.media-amazon.com/images/I/91op+qBsNZL.jpg", new AnswerModel[]
            {
                new AnswerModel(AnswersEnum.IThinkSo, new Dictionary<string,int>
                {
                    {"Strategy", 10 },
                }),
                new AnswerModel(AnswersEnum.Yes, new Dictionary<string,int>
                {
                    {"Strategy", 15 },
                    {"Role-Playing", 2 },
                    {"Simulation", 2 },
                }),
                new AnswerModel(AnswersEnum.No, new Dictionary<string,int>
                {
                    {"Action", 5 },
                    {"Adventure", 5 },
                    {"Platformers", 5 },
                    {"Shooter", 5 },
                }),
                new AnswerModel(AnswersEnum.IDontThinkSo, new Dictionary<string,int>
                {
                    {"Action", 2 },
                    {"Adventure", 2 },
                    {"Platformers", 2 },
                    {"Shooter", 2 },
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
