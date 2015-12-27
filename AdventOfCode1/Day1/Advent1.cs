using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1
{
	class Advent1
	{
		public void readFile()
		{
			using (StreamReader sr = new StreamReader(@"1.txt"))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					char[] array = line.ToCharArray();
					whichFloor(array);
				}
			}
		}

		public bool basementFloor(int floor)
		{
			if (floor == -1)
			{
				return true;
			}
			return false;
		}

		public void whichFloor(char[] input)
		{
			int result = 0;
			int step = 0;
			foreach (char dig in input)
			{
				step += 1;
				if (dig.Equals('('))
				{
					result += 1;
				}
				else
					if (dig.Equals(')'))
				{
					result -= 1;
				}
				bool floor = basementFloor(result);
				if (floor)
				{
					Console.WriteLine(step);
					break;
				}
			}
		}
	}
}
