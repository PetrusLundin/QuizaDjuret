using Microsoft.EntityFrameworkCore;
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

		public async Task<List<UserModel>> GetAllUsersAsync()
		{
			var users = await context.Highscore.Select(u => new UserModel
			{
				UserId = u.UserId,
				Name = u.Name,
				Score = u.Score
			}).ToListAsync();

			return users;
		}
	}
}
