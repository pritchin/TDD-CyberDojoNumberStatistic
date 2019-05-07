namespace CyberDojoNumberStatistic
{
	public class Calculator
	{
		public double Min(int[] sequence)
		{
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
	}
}