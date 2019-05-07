using System;
using System.Linq;

namespace CyberDojoNumberStatistic
{
	public class Calculator
	{
		public int Min(int[] sequence)
		{
			if (sequence == null)
			{
				throw new ArgumentNullException(nameof(sequence));
			}

			var min = int.MaxValue;
			
			foreach (var item in sequence)
			{
				if (item < min)
				{
					min = item;
				}
			}
			
			return min;
		}

		public double Max(int[] sequence)
		{
			if (sequence == null)
			{
				throw new ArgumentNullException(nameof(sequence));
			}
			
			var max = int.MinValue;
			
			foreach (var item in sequence)
			{
				if (item > max)
				{
					max = item;
				}
			}
			
			return max;
		}
	}
}