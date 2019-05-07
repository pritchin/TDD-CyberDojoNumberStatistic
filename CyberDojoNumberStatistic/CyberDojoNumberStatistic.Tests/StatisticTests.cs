using System;
using NUnit.Framework;

namespace CyberDojoNumberStatistic.Tests
{
	public class StatisticTests
	{
		[Test]
		public void WhenSequenceNull_ThrowsArgumentNullException()
		{
			var calculator = new Calculator();
			
			Assert.Throws<ArgumentNullException>(() =>
			{
				calculator.Min(null);
			});
		}
		
		[Test]
		public void WhenSequence_5_6_Return_5()
		{
			var sequence = new[] {5, 6};
			var calculator = new Calculator();
			
			var result = calculator.Min(sequence);
			
			Assert.AreEqual(5, result);
		}

		[Test]
		public void WhenSequence_6_7_8_Return_6()
		{
			var sequence = new[] {6,7,8};
			var calculator = new Calculator();
			
			var result = calculator.Min(sequence);
			
			Assert.AreEqual(6, result);
		}

		[Test]
		public void WhenSequence_5_6_Return_6()
		{
			var calculator = new Calculator();
			var sequence = new[] {5, 6};

			var result = calculator.Max(sequence);
			
			Assert.AreEqual(6, result);
		}
	}
}