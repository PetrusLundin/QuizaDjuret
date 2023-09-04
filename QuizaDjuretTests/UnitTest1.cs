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
			GameManager.CurrentQuestionNumber = 0;


			GameManager.NextQuestion();

			Assert.Equal(1, GameManager.CurrentQuestionNumber);
		}
	}
}