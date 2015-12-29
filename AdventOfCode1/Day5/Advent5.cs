using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1
{
	class Advent5
	{
		private int sum = 0;

		public void ReadFile()
		{
			using (StreamReader sr = new StreamReader(@"C:\Users\Shaq\Documents\5.txt"))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					char[] array = line.ToCharArray();
					NiceString(array);
				}
				Console.WriteLine(sum);
			}
		}

		public void NiceString(char[] array)
		{
			if (VowelsCheck(array) && DoubleCheck(array) && !WrongStringsCheck(array))
			{
				sum++;
			}
		}

		public bool VowelsCheck(char[] array)
		{
			int count = 0;
			char[] vowels = {'a', 'e', 'i', 'o', 'u'};

			foreach (char letter in array)
			{
				if (vowels.Contains(letter))
				{
					count++;
				}
			}
			if (count >= 3)
			{
				return true;
			}
			return false;
		}

		public bool DoubleCheck(char[] array)
		{
			for (int i = 0; i < array.Length - 1; i++)
			{
				if (array[i] == array[i + 1])
				{
					return true;
				}
			}
			return false;
		}

		public bool WrongStringsCheck(char[] array)
		{
			string[] wrongs = {"ab", "cd", "pq", "xy"};

			for (int i = 0; i < array.Length - 1; i++)
			{
				char[] twoDig = new char[2];
				twoDig[0] = array[i];
				twoDig[1] = array[i + 1];
				string s = new string(twoDig);
				if (wrongs.Contains(s))
				{
					return true;
				}
			}
			return false;
		}
	}
}