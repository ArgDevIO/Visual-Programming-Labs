using System;
using System.Linq;

namespace Lab12
{
	class Program
	{
		static void Main(string[] args)
		{
			int N;
			Console.WriteLine("Enter N:");
			N = Convert.ToInt32(Console.ReadLine());

			double sum = 0;
			int[] numbers = new int[N];
			Console.WriteLine("Enter {0} numbers:", N);
			for (int i = 0; i < N; i++)
			{
				numbers[i] = Convert.ToInt32(Console.ReadLine());
				sum += (double)numbers[i];
			}

			Console.WriteLine("The average of your numbers is: {0}", sum / numbers.Length);
			Console.WriteLine("The max number of your numbers is: {0}", numbers.Max());
			Console.WriteLine("The min number of your numbers is: {0}", numbers.Min());
		}
	}
}
