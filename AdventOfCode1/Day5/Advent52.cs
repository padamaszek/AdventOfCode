using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1.Day5
{
	class Advent52
	{
		private int sum = 0;

		public void ReadFile()
		{
			using (StreamReader sr = new StreamReader(@"5.txt"))
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
			if (TwoLettersTwiceCheck(array) && OneLetterRepeat(array))
			{
				sum++;
			}
		}

		public bool TwoLettersTwiceCheck(char[] array)
		{
			char[] twoDigs = new char[2];
			char[] twoDigsNext = new char[2];

			for (int i = 0; i < array.Length - 1; i++)
			{
				twoDigs[0] = array[i];
				twoDigs[1] = array[i + 1];
				for (int j = i + 2; j < array.Length - 1; j++)
				{
					twoDigsNext[0] = array[j];
					twoDigsNext[1] = array[j + 1];
					string one = new string(twoDigs);
					string two = new string(twoDigsNext);
					if (string.Compare(one, two) == 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		public bool OneLetterRepeat(char[] array)
		{
			for (int i = 0; i < array.Length - 2; i++)
			{
				char one = array[i];
				char two = array[i + 2];
				if (one == two)
				{
					return true;
				}
			}
			return false;
		}
	}
}