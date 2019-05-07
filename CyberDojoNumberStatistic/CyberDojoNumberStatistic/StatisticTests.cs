using NUnit.Framework;

namespace CyberDojoNumberStatistic
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
	}
}