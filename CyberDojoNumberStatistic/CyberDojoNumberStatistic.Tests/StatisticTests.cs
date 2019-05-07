using NUnit.Framework;

namespace CyberDojoNumberStatistic.Tests
{
	public class StatisticTests
	{
		[Test]
		public void MinTest()
		{
			var sequence = new[] {5, 6};
			var calculator = new Calculator();
			
			var result = calculator.Min(sequence);
			
			Assert.AreEqual(5, result);
		}

		[Test]
		public void METHOD()
		{
			var sequence = new[] {6,7,8};
			var calculator = new Calculator();
			var result = calculator.Min(sequence);
			
			Assert.AreEqual(6, result);
		}
	}
}