using Microsoft.AspNetCore.Mvc;
using QuizaDjuret.Server.Repository;
using QuizaDjuret.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuizaDjuret.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ScoreController : ControllerBase
	{
		private readonly ScoreRepo repo;

		public ScoreController(ScoreRepo repo)
		{
			this.repo = repo;
		}
		// POST api/<ScoreController>
		[HttpPost]
		public async Task<ActionResult<UserModel>> Post([FromBody] UserModel user)
		{
			var isCreatedSuccessful = await repo.AddUserAsync(user);

			if (isCreatedSuccessful)
			{
				return Ok();
			}
			return BadRequest();
		}

		[HttpGet]
		public async Task<ActionResult<List<UserModel>>> GetAllUsersAsync()
		{
			return Ok(await repo.GetAllUsersAsync());
		}


		//// GET: api/<ScoreController>
		//[HttpGet]
		//public IEnumerable<string> Get()
		//{
		//	return new string[] { "value1", "value2" };
		//}

		//// GET api/<ScoreController>/5
		//[HttpGet("{id}")]
		//public string Get(int id)
		//{
		//	return "value";
		//}



		//// PUT api/<ScoreController>/5
		//[HttpPut("{id}")]
		//public void Put(int id, [FromBody] string value)
		//{
		//}

		//// DELETE api/<ScoreController>/5
		//[HttpDelete("{id}")]
		//public void Delete(int id)
		//{
		//}
	}
}
