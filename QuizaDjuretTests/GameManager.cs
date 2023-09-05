using QuizaDjuret.Client.Managers;
using QuizaDjuret.Shared;

namespace QuizaDjuretTests
{
	public class GameManager
	{
        public GameManager()
        {
            QuizaDjuret.Client.Managers.GameManager.Questions = new() 
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
            QuizaDjuret.Client.Managers.GameManager.CurrentQuestionNumber = 0;

            // Act
            QuizaDjuret.Client.Managers.GameManager.NextQuestion();

            // Assert
            Assert.Equal(1, QuizaDjuret.Client.Managers.GameManager.CurrentQuestionNumber);
		}

		[Fact]
		public void ResetQuiz_Test()
		{
            // Arrange
            QuizaDjuret.Client.Managers.GameManager.CurrentQuestionNumber = 69;

            // Act
            QuizaDjuret.Client.Managers.GameManager.ResetQuiz();

            // Assert
            Assert.Equal(0, QuizaDjuret.Client.Managers.GameManager.CurrentQuestionNumber);
		}

	}
}