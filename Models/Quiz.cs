namespace QuizApp3.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Question> Questions { get; set; }
        public int UserId { get; set; }
        public Player User { get; set; }
    }
}
