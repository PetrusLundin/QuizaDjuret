using Newtonsoft.Json;
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

        public async Task<QuestionModel> Testget(int id)
        {
            var response = await httpClient.GetAsync($"api/quiz/{id}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var quiz = JsonConvert.DeserializeObject<QuestionModel>(json);
                return quiz;
            }
            return null;
        }
    }
}
