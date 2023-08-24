using QuizaDjuret.Shared;

namespace QuizaDjuret.Client.Managers
{
    public static class GameManager
    {
        public static QuestionModel Question { get; set; } = new();
        //public static List<QuestionModel> Questions { get; set; } = new();
        public static int CurrentQuestion { get; set; } = 0;
        public static string CurrentQuestionText { get; set; } = "";

        public static bool isRunning { get; set; } = false;

        public static void NextQuestion()
        {
            CurrentQuestion++;
            //TODO plocka rätt fråga ur array
            CurrentQuestionText = Question.Text;
            //ändra svaren
            //ändra hint
            //ändra bild
        }


        public static void ResetQuiz()
        {
            CurrentQuestion = 0;
        }
    }
}
