using System.Collections.Generic;

namespace GamingQuiz.Models
{
    public class AnswerModel
    {
        public AnswerModel(Dictionary<GenresEnum, int> PointsToCategories)
        {
            this.PointsToCategories = PointsToCategories;
        }
        public Dictionary<GenresEnum, int> PointsToCategories;
    }
}
