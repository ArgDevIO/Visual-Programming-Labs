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

			Console.WriteLine("Do you want to generate random numbers or enter them manually?");
			Console.WriteLine("1 - Generate random numbers\n2 - Enter numbers manually");
			bool isValid = true;

			do
			{
				isValid = true;
				switch (Convert.ToInt32(Console.ReadLine()))
				{
					case 1:
						Console.WriteLine("Generating {0} random numbers...", N);
						for (int i = 0; i < N; i++)
						{
							numbers[i] = random.Next(1, 1000);
							sum += (double)numbers[i];
						}
						break;
						
					case 2:
						Console.WriteLine("Enter {0} numbers:", N);
						for (int i = 0; i < N; i++)
						{
							numbers[i] = Convert.ToInt32(Console.ReadLine());
							sum += (double)numbers[i];
						}
						break;
						
					default:
						Console.WriteLine("Invalid Choice");
						isValid = false;
						break;
				}
			}
			while (!isValid);

			Console.WriteLine("The average of your numbers is: {0}", sum / numbers.Length);
			Console.WriteLine("The max number of your numbers is: {0}", numbers.Max());
			Console.WriteLine("The min number of your numbers is: {0}", numbers.Min());
		}
	}
}
