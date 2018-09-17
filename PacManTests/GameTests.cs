using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PacManChallenge;

namespace PacManTests
{
	[TestClass]
	public class GameTests
	{
		[TestMethod]
		public void Game_Start_ShouldBeExpectedOutput()
		{
			//-- arrange
			var mockGame = new Game(new MockConsole());

			//-- act


			//-- assert
		}
	}
}
