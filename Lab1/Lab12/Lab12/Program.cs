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
			Random random = new Random();

			int[] numbers = new int[N];
			Console.WriteLine("Generating {0} random numbers...", N);
			for (int i = 0; i < N; i++)
			{
				numbers[i] = random.Next(1, 1000);
				sum += (double)numbers[i];
			}

			Console.WriteLine("The average of your numbers is: {0}", sum / numbers.Length);
			Console.WriteLine("The max number of your numbers is: {0}", numbers.Max());
			Console.WriteLine("The min number of your numbers is: {0}", numbers.Min());
		}
	}
}
