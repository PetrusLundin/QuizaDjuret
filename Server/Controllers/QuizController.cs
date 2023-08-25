using Microsoft.AspNetCore.Mvc;
using QuizaDjuret.Server.Repository;
using QuizaDjuret.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuizaDjuret.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class QuizController : ControllerBase
	{
		private readonly QuizRepo repo;

		public QuizController(QuizRepo repo)
		{
			this.repo = repo;
		}

		[HttpGet]
		public async Task<ActionResult<List<QuestionModel>>> Get()
		{
			return Ok(await repo.GetAllQuestions());
		}
	}
}
