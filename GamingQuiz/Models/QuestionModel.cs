namespace GamingQuiz.Models
{
    public class QuestionModel
    {
        public QuestionModel(string questionText, string questionImagePath, AnswerModel[] answers)
        {
            this.questionText = questionText;
            this.questionImagePath = questionImagePath;
            this.answers = answers;
        }
        public string questionText { get; set; }
        public string questionImagePath { get; set; }
        public AnswerModel[] answers { get; set; }
    }
}
