using Microsoft.AspNetCore.Mvc;
using QuizaDjuret.Server.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuizaDjuret.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AnswerController : ControllerBase
	{
		private readonly QuizRepo quizRepo;

		public AnswerController(QuizRepo quizRepo)
		{
			this.quizRepo = quizRepo;
		}

		//[HttpGet("{questionId}")]
		//public async Task<ActionResult<AnswerModel?>> Get(int questionId)
		//{
		//    return Ok(await quizRepo.GetQuestionWithAnswers(questionId));
		//}
	}
}
