﻿using System;

namespace Lab14
{
	class Program
	{
		static void Main(string[] args)
		{
			string myString = "This is a test.";
			char[] separator = { ' ' };
			string[] myWords;
			myWords = myString.Split(separator);
			foreach (string word in myWords)
			{
				Console.WriteLine("{0}", word);
			}
			Console.ReadKey();
		}
	}
}
