using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace QuizaDjuretTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void NextQuestion_Test()
		{
			//Arrange
			GameManager.CurrentQuestionNumber = 0;
		}
	}
}
