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

		public async Task<List<QuestionModel>> GetAllQuestionsAsync()
		{
			var questions = await context.Questions.Include(r => r.Answers).Select(q => new QuestionModel
			{
				QuestionId = q.QuestionId,
				CorrectAnswerId = q.CorrectAnswerId,
				Text = q.Text,
				Hint = q.Hint,
				FunFact = q.FunFact,
				MediaURL = q.MediaURL,
				DifficultyLevel = q.DifficultyLevel,
				Answers = q.Answers
			})
				.ToListAsync();

			return questions;
		}
	}
}
