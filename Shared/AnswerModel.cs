using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizaDjuret.Shared
{
    public class AnswerModel
    {
        [Key]
        public int AnswerId { get; set; }
        [ForeignKey(nameof(Question))]
        public int QuestionId { get; set; }
        public QuestionModel Question { get; set; }
        public bool IsCorrect { get; set; }
        public string Text { get; set; } = null!;

    }
}
