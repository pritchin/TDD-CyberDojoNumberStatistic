using System;
using System.Linq;
using NUnit.Framework;

namespace CyberDojoNumberStatistic.Tests
{
	public class StatisticTests
	{
		[Test]
		public void Min_WhenSequence_5_6_Return_5()
		{
			var sequence = new[] {5, 6};
			var calculator = new Calculator(sequence);

			var result = calculator.Min();

			Assert.AreEqual(5, result);
		}

		[Test]
		public void Min_WhenSequence_6_7_8_Return_6()
		{
			var sequence = new[] {6, 7, 8};
			var calculator = new Calculator(sequence);

			var result = calculator.Min();

			Assert.AreEqual(6, result);
		}

		[Test]
		public void Max_WhenSequence_5_6_Return_6()
		{
			var sequence = new[] {5, 6};
			var calculator = new Calculator(sequence);

			var result = calculator.Max();

			Assert.AreEqual(6, result);
		}

		[Test]
		public void Max_WhenSequence_5_6_7_Return_7()
		{
			var sequence = new[] {5, 6, 7};
			var calculator = new Calculator(sequence);

			var result = calculator.Max();

			Assert.AreEqual(7, result);
		}

		[Test]
		public void Max_WhenSequence_1_range_200_Return_200()
		{
			var sequence = Enumerable.Range(1, 200).ToArray();
			var calculator = new Calculator(sequence);

			var result = calculator.Max();

			Assert.AreEqual(200, result);
		}

		[Test]
		public void WhenSequenceNull_ThrowsArgumentNullException()
		{
			// ReSharper disable once ObjectCreationAsStatement
			Assert.Throws<ArgumentNullException>(() => new Calculator(null));
		}
	}
}