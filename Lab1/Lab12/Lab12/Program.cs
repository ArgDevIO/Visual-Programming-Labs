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
				int choice = Convert.ToInt32(Console.ReadLine());
				isValid = choice <= 2;

				if (isValid)
				{
					GenerateOrReadNumbers(choice, ref numbers, ref sum);
					break;
				}
				else
					Console.WriteLine("Invalid choice!\n1 - Generate random numbers\n2 - Enter numbers manually");
			}
			while (!isValid);

			Console.WriteLine("The average of your numbers is: {0}", sum / numbers.Length);
			Console.WriteLine("The max number of your numbers is: {0}", numbers.Max());
			Console.WriteLine("The min number of your numbers is: {0}", numbers.Min());
		}

		/// <summary>
		/// Generating random numbers or reading them from Console.ReadLine() depending on the choice
		/// 1 - Generate random numbers
		/// 2 - Enter numbers manually
		/// </summary>
		/// <param name="choice"></param>
		/// <param name="numbers"></param>
		/// <param name="sum"></param>
		private static void GenerateOrReadNumbers(int choice, ref int[] numbers, ref double sum)
		{
			Random random = new Random();
			string message = (choice == 1) ? "Generating {0} random numbers..." : "Enter {0} numbers:";
			Console.WriteLine(message, numbers.Length);

			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = (choice == 1) ? random.Next(1, 1000) : Convert.ToInt32(Console.ReadLine());
				sum += (double)numbers[i];
			}
		}
	}
}
