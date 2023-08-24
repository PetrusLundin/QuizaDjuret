namespace QuizaDjuret.Client.Managers
{
    public static class GameManager
    {
        public static int CurrentQuestion { get; set; } = 0;

        public static bool isRunning { get; set; } = false;

        public static void NextQuestion()
        {
            CurrentQuestion++;
        }

        //public static void StartGame()
        //{

        //}
    }
}
