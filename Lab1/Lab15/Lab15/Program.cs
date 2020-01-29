using System;

namespace Lab15
{
	class Program
	{
		enum PasswordStrength 
		{
			easy,
			normal,
			hard
		}

		 
		static void Main(string[] args)
		{
			String[] passwords = Console.ReadLine().Split(' ');

			Console.WriteLine("You entered these passwords:");
			foreach (string psw in passwords) Console.Write("- {0}", psw);

			var easyPaswObj = new
			{
				minLength = 0,
				maxLength = 6
			};

			Console.WriteLine("Generating passwords...");
			string easyPasw = generatePassword(PasswordStrength.easy);
			string normalPasw = generatePassword(PasswordStrength.normal);
			string hardyPasw = generatePassword(PasswordStrength.hard);
		}

		static string generatePassword(PasswordStrength passwordStrength)
		{
			switch (passwordStrength)
			{
				case PasswordStrength.easy:
					return getPassword(1, 6, true, false, false, false);
			}
			return null;
		}

		static string getPassword(int minLength, int maxLength, bool lowercase, bool uppercase, bool digits, bool specialchars)
		{

		}
	}
}
