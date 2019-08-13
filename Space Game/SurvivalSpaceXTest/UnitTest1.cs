using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SurvivalSpaceXLibrary;
using Survival_Space_X;

namespace SurvivalSpaceXTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Character character = new Character();
			Calculation calculation = new Calculation();
			calculation.calAddGold(character);
			Assert.AreEqual(300, character.Storage.Coin);

		}
	}
}
