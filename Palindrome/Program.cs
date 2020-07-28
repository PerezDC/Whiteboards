using System;

namespace Palindrome
{
	class Program
	{
		static bool isPalindrom(string inputString)
		{
			string word = inputString.Replace(" ", "");
			int i = 0;
			int j = word.Length - 1;
            while (j > i)
            {
				if (word[i] != word[j])
				{
					return false;
				}

				i++;
				j--;

			}

			return true;
		}

		static void Main(string[] args)
		{
			Console.WriteLine($"The answer is {isPalindrom("david")}");
		}
	}
}


