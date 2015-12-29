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

		public void ReadFile()
		{
			using (StreamReader sw = new StreamReader(@"2.txt"))
			{
				string line;
				while ((line = sw.ReadLine()) != null)
				{
					string[] splitted = line.Split('x');
					Ribbon(splitted);
					//wrap(splitted);
				}
				Console.WriteLine(sumOfAll);
			}
		}

		void Wrap(string[] present)
		{
			int l = Convert.ToInt32(present[0]);
			int w = Convert.ToInt32(present[1]);
			int h = Convert.ToInt32(present[2]);
			resultOfOne = 2*l*w + 2*w*h + 2*h*l + SmallestSide(l, h, w);
			sumOfAll += resultOfOne;
		}

		int SmallestSide(int l, int w, int h)
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

		void Ribbon(string[] present)
		{
			int l = Convert.ToInt32(present[0]);
			int w = Convert.ToInt32(present[1]);
			int h = Convert.ToInt32(present[2]);
			resultOfOne = l*w*h + SmallestSide(l, w, h);
			sumOfAll += resultOfOne;
		}
	}
}