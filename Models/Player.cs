using Microsoft.AspNetCore.Identity;

namespace QuizApp3.Models
{
    public class Player : IdentityUser
    {
        public List<Quiz> Quizzes { get; set; }
    }
}
