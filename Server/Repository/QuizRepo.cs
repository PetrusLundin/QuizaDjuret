using Microsoft.EntityFrameworkCore;
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

		public async Task <List<QuestionModel>> GetAllQuestions()
		{
			var question = await context.Questions.ToListAsync();

			return question;
		}

		public async Task<List<AnswerModel>> GetAllAnswers()
		{
			var answer = await context.Answers.ToListAsync();

			return answer;
		}
	}
}
