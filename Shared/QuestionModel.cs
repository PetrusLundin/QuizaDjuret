﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizaDjuret.Shared
{
    public class QuestionModel
    {
        public int QuestionId { get; set; }
        public int CorrectAnswerId { get; set; }
        public string Text { get; set; } = null!;
        public string Hint { get; set; } = null!;
        public string FunFact { get; set; } = null!;
        public string ImageURL { get; set; } = null!;
        public int DifficultyLevel { get; set; }
        public List<AnswerModel> Answers { get; set; } = new();
    }
}
