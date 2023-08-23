﻿using Microsoft.EntityFrameworkCore;
using QuizaDjuret.Server.Data;
using QuizaDjuret.Shared;

namespace QuizaDjuret.Server.Repository
{
    public class QuizRepo
    {
        private readonly AppDbContext context;

        public QuizRepo(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<QuestionModel> TestGetquestion()
        {
            var testtest = await context.Questions.FirstOrDefaultAsync();
            return testtest;
        }
    }
}
