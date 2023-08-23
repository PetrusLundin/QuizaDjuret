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
        // GET: api/<QuizController>
        [HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<QuizController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<QuestionModel>> Get(int id)
		{
			//return "value";
			var testest = Ok(await repo.TestGetquestion());
			return testest;

		}

		// POST api/<QuizController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<QuizController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<QuizController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
