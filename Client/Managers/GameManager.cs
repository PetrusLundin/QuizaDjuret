using QuizaDjuret.Shared;

namespace QuizaDjuret.Client.Managers
{
	public static class GameManager
	{
		public static int QuestionsPerLevel { get; set; } = 5;

		public static List<QuestionModel> Questions { get; set; } = new();
		public static List<QuestionModel> UsedQuestions { get; set; } = new();
		public static List<AnswerModel> Answers { get; set; } = new();
		public static int CurrentQuestionNumber { get; set; } = 0;
		public static QuestionModel? CurrentQuestion { get; set; }
		public static bool isCorrectAnswer { get; set; } = false;

		public static void NextQuestion()
		{
			CurrentQuestionNumber++;

			if (CurrentQuestionNumber <= QuestionsPerLevel)
			{
				CurrentQuestion = GetRandomQuestion(1);
			}
			else if (CurrentQuestionNumber <= 2 * (QuestionsPerLevel))
			{
				CurrentQuestion = GetRandomQuestion(2);
			}
			else if (CurrentQuestionNumber <= 3 * (QuestionsPerLevel))
			{
				CurrentQuestion = GetRandomQuestion(3);
			}
			else if (CurrentQuestionNumber <= 4 * (QuestionsPerLevel))
			{
				CurrentQuestion = GetRandomQuestion(4);
			}
			else
			{
				CurrentQuestionNumber = 41;
			}
			var rng = new Random();
			CurrentQuestion.Answers = CurrentQuestion.Answers.OrderBy(a => rng.Next()).ToList();

			ScoreManager.RestoreCurrentPoints();
			ScoreManager.SortScoreboard();
		}
		public static void ResetQuiz()
		{
			CurrentQuestionNumber = 0;
			UsedQuestions.Clear();
		}

		public static QuestionModel? GetRandomQuestion(int difficulty)
		{
			List<QuestionModel> questionsAtDifficulty = Questions.Where(q => q.DifficultyLevel == difficulty).ToList();

			Random random = new Random();

			int randomIndex = random.Next(questionsAtDifficulty.Count);
			QuestionModel randomQ = questionsAtDifficulty[randomIndex];

			while (UsedQuestions.Contains(randomQ))
			{
				randomIndex = random.Next(questionsAtDifficulty.Count);
				randomQ = questionsAtDifficulty[randomIndex];
			}
			UsedQuestions.Add(randomQ);
			return randomQ;
		}
	}
}
