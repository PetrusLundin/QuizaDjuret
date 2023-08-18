using Microsoft.EntityFrameworkCore;
using QuizaDjuret.Shared;

namespace QuizaDjuret.Server.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base (options)
        {
            
        }

        public DbSet<UserModel> Highscore { get; set; }
        public DbSet<AnswerModel> Answers { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
    }
}
