using QuizaDjuret.Server.Data;
using QuizaDjuret.Shared;

namespace QuizaDjuret.Server.Repository
{
	public class ScoreRepo
	{
		private readonly AppDbContext context;

		public ScoreRepo(AppDbContext context)
		{
			this.context = context;
		}

		public async Task<bool> AddUserAsync(UserModel userToAdd)
		{
			context.Highscore.Add(userToAdd);
			await context.SaveChangesAsync();

			return true;
		}
	}
}
