namespace QuizApp3.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsCorrect { get; set; } // Anger om detta är det korrekta svaret
        public int QuestionId { get; set; } // ID:t för frågan som detta svar tillhör
        public Question Question { get; set; } // Frågan som detta svar tillhör
    }
}
