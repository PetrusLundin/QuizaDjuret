using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizaDjuret.Shared
{
    public class AnswerModel
    {
        [Key]
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public QuestionModel Question { get; set; } = new();
        public bool IsCorrect { get; set; }
        public string Text { get; set; } = null!;

    }
}
