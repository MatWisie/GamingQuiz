﻿using GamingQuiz.Models;
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
