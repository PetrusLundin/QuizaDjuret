﻿using Newtonsoft.Json;
using QuizaDjuret.Shared;

namespace QuizaDjuret.Client.Services
{
	public class QuizService
	{
		private readonly HttpClient httpClient;

		public QuizService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}

		public async Task<List<QuestionModel>> GetAllAsync()
		{
			var response = await httpClient.GetAsync($"api/quiz");
			if (response.IsSuccessStatusCode)
			{
				var json = await response.Content.ReadAsStringAsync();
				var quiz = JsonConvert.DeserializeObject<List<QuestionModel>>(json);
				return quiz;
			}
			return null;
		}

		//public async Task<List<AnswerModel>> GetAnswers(int questionId)
		//{
		//    var answerResponse = await httpClient.GetAsync($"api/answer/{questionId}");
		//    if (answerResponse.IsSuccessStatusCode)
		//    {
		//        var answerjson = await answerResponse.Content.ReadAsStringAsync();
		//        var answer = JsonConvert.DeserializeObject<List<AnswerModel>>(answerjson);
		//        return answer;

		//    }

		//    return null;
		//}
	}
}
