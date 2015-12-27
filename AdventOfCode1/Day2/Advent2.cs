using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1
{
	class Advent2
	{
		int resultOfOne = 0;
		int sumOfAll = 0;

		public void readFile()
		{
			using (StreamReader sw = new StreamReader(@"2.txt"))
			{
				string line;
				while ((line= sw.ReadLine()) != null)
				{
					string[] splitted = line.Split('x');
					ribbon(splitted);
					//wrap(splitted);
				}
				Console.WriteLine(sumOfAll);
			}
		}

		void wrap(string[] present)
		{
			int l = Convert.ToInt32(present[0]);
			int w = Convert.ToInt32(present[1]);
			int h = Convert.ToInt32(present[2]);
			resultOfOne = 2*l*w + 2*w*h + 2*h*l + smallestSide(l, h, w);
			sumOfAll += resultOfOne;

		}

		int smallestSide(int l, int w, int h)
		{
			int min1;
			int min2;
			if (l <= w || l <= h)
			{
				min1 = l;
				if (w <= h)
				{
					min2 = w;
				}
				else
				{
					min2 = h;
				}
			}
			else
			{
				min1 = w;
				min2 = h;
			}
			return min1 + min1 + min2 + min2;
		}

		void ribbon(string[] present)
		{
			int l = Convert.ToInt32(present[0]);
			int w = Convert.ToInt32(present[1]);
			int h = Convert.ToInt32(present[2]);
			resultOfOne = l*w*h + smallestSide(l, w, h);
			sumOfAll += resultOfOne;
		}
	}
}