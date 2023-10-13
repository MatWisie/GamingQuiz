using System.Collections.Generic;

namespace GamingQuiz.Models
{
    public class AnswerModel
    {
        public AnswerModel(AnswersEnum name, Dictionary<string, int> PointsToCategories)
        {
            this.PointsToCategories = PointsToCategories;
            Name = name;
        }
        public AnswersEnum Name;
        public Dictionary<string, int> PointsToCategories;
    }
}
