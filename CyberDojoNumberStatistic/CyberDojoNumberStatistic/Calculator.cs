using System;

namespace CyberDojoNumberStatistic
{
	public class Calculator
	{
		private readonly int[] _sequence;

		public Calculator(int[] sequence)
		{
			if (sequence == null)
			{
				throw new ArgumentNullException(nameof(sequence));
			}
			
			this._sequence = sequence;
		}
		
		public int Min()
		{
			if (_sequence == null)
			{
				throw new ArgumentNullException(nameof(_sequence));
			}

			var min = int.MaxValue;
			
			foreach (var item in _sequence)
			{
				if (item < min)
				{
					min = item;
				}
			}
			
			return min;
		}

		public double Max()
		{
			if (_sequence == null)
			{
				throw new ArgumentNullException(nameof(_sequence));
			}
			
			var max = int.MinValue;
			
			foreach (var item in _sequence)
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