using QuizaDjuret.Server.Data;

namespace QuizaDjuret.Server.Repository
{
	public class LeaderboardRepo
	{
		private readonly AppDbContext context;
		public LeaderboardRepo(AppDbContext context)
        {
              this.context = context;
        }
    }
}
