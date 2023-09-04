using QuizaDjuret.Client.Managers;
using QuizaDjuret.Shared;

namespace QuizaDjuretTests
{
	public class UnitTest1
	{
        public UnitTest1()
        {
			GameManager.Questions = new() 
			{
				new QuestionModel { },
				new QuestionModel { },
				new QuestionModel { },
			};
		}
        [Fact]
		public void NextQuestion_Test()
		{
			// Arrange
			GameManager.CurrentQuestionNumber = 0;

			// Act
			GameManager.NextQuestion();

			// Assert
			Assert.Equal(1, GameManager.CurrentQuestionNumber);
		}

		[Fact]
		public void ResetQuiz_Test()
		{
			// Arrange
			GameManager.CurrentQuestionNumber = 69;

			// Act
			GameManager.ResetQuiz();

			// Assert
			Assert.Equal(0, GameManager.CurrentQuestionNumber);
		}

	}
}