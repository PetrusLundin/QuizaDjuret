using Newtonsoft.Json;
using QuizaDjuret.Client.Managers;
using QuizaDjuret.Shared;
using System.Net.Http.Json;

namespace QuizaDjuret.Client.Services
{
	public class ScoreService
	{
		private readonly HttpClient httpClient;

		public ScoreService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}

		public async Task<List<UserModel>> GetAllUsersAsync()
		{
			var response = await httpClient.GetAsync($"api/score");
			if (response.IsSuccessStatusCode)
			{
				var json = await response.Content.ReadAsStringAsync();
				var scoreboard = JsonConvert.DeserializeObject<List<UserModel>>(json);
				return scoreboard;
			}
			return new List<UserModel>();
		}

		public async Task<bool> AddUserScore(string playerName)
		{
			UserModel user = new()
			{
				Name = playerName,
				Score = ScoreManager.Score
			};
			var response = await httpClient.PostAsJsonAsync<UserModel>("api/score", user);

			if (response.IsSuccessStatusCode)
			{
				return true;
			}
			return false;
		}
	}
}
