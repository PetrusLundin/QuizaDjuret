using QuizaDjuret.Shared;

namespace QuizaDjuret.Client.Managers
{
    public static class GameManager
    {
        public static List<QuestionModel> Questions { get; set; } = new();
        public static int CurrentQuestion { get; set; } = 0;
        public static string CurrentQuestionText { get; set; } = "";

        public static bool isRunning { get; set; } = false;

        public static void NextQuestion()
        {
            if (CurrentQuestion <  Questions.Count - 1)
            {
                CurrentQuestion++;
                CurrentQuestionText = Questions[CurrentQuestion].Text;
            }
            else
            {
                isRunning = false;
                CurrentQuestionText = "No more Questions";
            }
            //TODO plocka rätt fråga ur array
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
