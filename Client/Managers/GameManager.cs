using QuizaDjuret.Shared;

namespace QuizaDjuret.Client.Managers
{
	public static class GameManager
	{
		public static List<QuestionModel> Questions { get; set; } = new();
		public static List<AnswerModel> Answers { get; set; } = new();
		//TODO plocka questionmodel på currentquestion för att tracka i index sen?
		public static int CurrentQuestionNumber { get; set; } = 0;
		public static QuestionModel? CurrentQuestion { get; set; }
		public static bool isRunning { get; set; } = false;
		public static bool isCorrectAnswer { get; set; } = false;

		public static void NextQuestion()
		{
			CurrentQuestionNumber++;
			CurrentQuestion = Questions[CurrentQuestionNumber - 1];
			var rng = new Random();
			CurrentQuestion.Answers = CurrentQuestion.Answers.OrderBy(a => rng.Next()).ToList();
		}
		public static void ResetQuiz()
		{
			CurrentQuestionNumber = 0;
		}
	}
}
