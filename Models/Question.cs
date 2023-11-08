namespace QuizApp3.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }
        public int CorrectAnswerId { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
    }
}
