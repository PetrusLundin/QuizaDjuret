namespace QuizaDjuret.Client.Managers
{
	public static class ScoreManager
	{
		static public int Score { get; set; }
		static public int CurrentPoints { get; set; }
		static public int WinStreak { get; set; }

		static public void Add()
		{
			WinStreak++;
			if (WinStreak >= 3)
			{
				CurrentPoints += 500;
			}
			Score += CurrentPoints;
		}
		static public void RestoreCurrentPoints()
		{
			CurrentPoints = 100;
		}
		static public void ReduceCurrentPoints()
		{
			WinStreak = 0;
			CurrentPoints /= 2;
		}

		static public void ResetPoints()
		{
			Score = 0;
		}
	}
}