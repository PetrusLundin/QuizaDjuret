using Microsoft.EntityFrameworkCore;
using QuizaDjuret.Shared;

namespace QuizaDjuret.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<UserModel> Highscore { get; set; }
        public DbSet<AnswerModel> Answers { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder); -klassiker -Gabriel 2k23
            modelBuilder.Entity<QuestionModel>().HasMany(u => u.Answers).WithOne(r => r.Question).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<QuestionModel>().HasData(
                new QuestionModel
                {
                    QuestionId = 1,
                    Text = "Vad är dens största kända arten av sköldpadda?",
                    CorrectAnswerId = 1,
                    Hint = "Denna sköldpadda kan väga upp till 900kilogram och lever i havet.",
                    FunFact = " Denna imponerande sköldpadda kallas för lädersköldpadda och har en kraftig kroppsstruktur som skyddar den mot rovdjur. Den är också känd för att kunna dyka på stora djup och stanna under vattnet i flera timmar innan den måste andas luft.",
                    ImageURL = "sköldis.jpg",
                    DifficultyLevel = 1
                }
            );

            modelBuilder.Entity<AnswerModel>().HasData(
                new AnswerModel { AnswerId = 1, QuestionId = 1, IsCorrect = true, Text = "Dermochelys coriacea" },
                new AnswerModel { AnswerId = 2, QuestionId = 1, IsCorrect = false, Text = "SkalMan" },
                new AnswerModel { AnswerId = 3, QuestionId = 1, IsCorrect = false, Text = "Rafetus Swinhoei" }
            );
        }
    }
}
