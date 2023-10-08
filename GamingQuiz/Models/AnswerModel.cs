using System.Collections.Generic;

namespace GamingQuiz.Models
{
    public class AnswerModel
    {
        public AnswerModel(AnswersEnum name, Dictionary<GenresEnum, int> PointsToCategories)
        {
            this.PointsToCategories = PointsToCategories;
            Name = name;
        }
        public AnswersEnum Name;
        public Dictionary<GenresEnum, int> PointsToCategories;
    }
}
