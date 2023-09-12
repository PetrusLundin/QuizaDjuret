using QuizaDjuret.Shared;

namespace QuizaDjuret.Client.Managers
{
	public static class GameManager
	{
		public static List<QuestionModel> Questions { get; set; } = new();
		public static List<AnswerModel> Answers { get; set; } = new();
		public static int CurrentQuestionNumber { get; set; } = 0;
		public static QuestionModel? CurrentQuestion { get; set; }
		public static bool isCorrectAnswer { get; set; } = false;

		public static void NextQuestion()
		{
			CurrentQuestionNumber++;
			if (CurrentQuestionNumber <= 40)
			{
				CurrentQuestion = Questions[CurrentQuestionNumber - 1];
				var rng = new Random();
				CurrentQuestion.Answers = CurrentQuestion.Answers.OrderBy(a => rng.Next()).ToList();
			}
			ScoreManager.RestoreCurrentPoints();
			ScoreManager.SortScoreboard();
		}
		public static void ResetQuiz()
		{
			CurrentQuestionNumber = 0;
		}
	}
}
