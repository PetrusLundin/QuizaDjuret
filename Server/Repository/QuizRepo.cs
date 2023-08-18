using QuizaDjuret.Server.Data;

namespace QuizaDjuret.Server.Repository
{
    public class QuizRepo
    {
        private readonly AppDbContext context;

        public QuizRepo(AppDbContext context)
        {
            this.context = context;
        }
    }
}
