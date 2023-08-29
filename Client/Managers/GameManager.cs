using QuizaDjuret.Client.Services;
using QuizaDjuret.Shared;

namespace QuizaDjuret.Client.Managers
{
    public static class GameManager
    {
        public static List<QuestionModel> Questions { get; set; } = new();
        public static List<AnswerModel> Answers { get; set; } = new();
        //TODO plocka questionmodel på currentquestion för att tracka i index sen?
        public static int CurrentQuestion { get; set; } = 0;
        public static string CurrentQuestionText { get; set; } = "";
        public static string CurrentQuestionHint { get; set; } = "";
        public static string CurrentQuestionImage { get; set; } = "";
        public static string CurrentQuestionFunFact { get; set; } = "";
        public static string CurrentAnswer { get; set; } = "";

        public static bool isRunning { get; set; } = false;

        public static void NextQuestion()
        {
            if (CurrentQuestion < Questions.Count)
            {
                //TODO plocka rätt fråga ur array baserat på svårighetsgrad 1-10, 11-20 osv
                CurrentQuestion++;
                CurrentQuestionText = Questions[CurrentQuestion - 1].Text;
                CurrentQuestionHint = Questions[CurrentQuestion - 1].Hint;
                CurrentQuestionFunFact = Questions[CurrentQuestion - 1].FunFact;
                CurrentQuestionImage = Questions[CurrentQuestion - 1].ImageURL;
                
            }
            else
            {
                isRunning = false;
                CurrentQuestionText = "No more Questions";
            }
        }
        public static void ResetQuiz()
        {
            CurrentQuestion = 0;
        }


    }
}
