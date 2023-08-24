namespace QuizaDjuret.Client.Managers
{
    public static class GameManager
    {
        public static int CurrentQuestion { get; set; }

        public static bool isRunning { get; set; } = false;

        public static void NextQuestion()
        {
            CurrentQuestion++;
        }
        
    }
}
