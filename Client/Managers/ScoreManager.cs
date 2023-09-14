using QuizaDjuret.Shared;

namespace QuizaDjuret.Client.Managers
{
	public static class ScoreManager
	{
		static public UserModel CurrentUser { get; set; } = new() { Name = "DU", Score = 0 };
		static public int CurrentQuestionPoints { get; set; }
		static public int WinStreak { get; set; }
		static public List<UserModel> ScoreBoard { get; set; } = new();

		static public void IncrementWinStreak()
		{
			WinStreak++;
			if (WinStreak >= 3)
			{
				CurrentQuestionPoints += 50;
			}
		}
		static public void Add()
		{
			CurrentUser.Score += CurrentQuestionPoints;
			SortScoreboard();
		}
		static public void RestoreCurrentPoints()
		{
			CurrentQuestionPoints = 100;
		}
		static public void ReduceCurrentQuestionPoints()
		{
			WinStreak = 0;
			CurrentQuestionPoints /= 2;
		}

		static public void ResetCurrentUser()
		{
			WinStreak = 0;
			CurrentUser.Name = "DU";
			CurrentUser.Score = 0;
		}

		static public void SortScoreboard()
		{
			ScoreBoard.Sort((x, y) => y.Score.CompareTo(x.Score));
		}

		static public List<UserModel> GetDynamicScoreBoard()
		{
			List<UserModel> dynamicList = new();
			int userIndex = ScoreBoard.IndexOf(CurrentUser);
			if (ScoreBoard.Count <= 10)
			{
				dynamicList = ScoreBoard.GetRange(0, ScoreBoard.Count);
			}
			else if (userIndex < 11)
			{
				dynamicList = ScoreBoard.GetRange(0, 11);
			}
			else
			{
				dynamicList = ScoreBoard.GetRange(0, 3);
				dynamicList.Add(new()
				{
					Name = "",
					Score = 0,
				});
				dynamicList.Add(ScoreBoard[userIndex - 3]);
				dynamicList.Add(ScoreBoard[userIndex - 2]);
				dynamicList.Add(ScoreBoard[userIndex - 1]);
				dynamicList.Add(ScoreBoard[userIndex]);
				if (ScoreBoard.Count - (userIndex + 1) > 0)
				{
					dynamicList.Add(ScoreBoard[userIndex + 1]);
				}
				if (ScoreBoard.Count - (userIndex + 1) > 1)
				{
					dynamicList.Add(ScoreBoard[userIndex + 2]);
				}
				if (ScoreBoard.Count - (userIndex + 1) > 2)
				{
					dynamicList.Add(ScoreBoard[userIndex + 3]);
				}
				//TODO clone list to add meddallionsss

			}

			return dynamicList;
		}
	}
}