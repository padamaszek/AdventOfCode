using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1
{
	class Advent3
	{
		List<Point> points = new List<Point>();
		private int x = 0;
		private int y = 0;
		private int sum = 0;

		public struct Point
		{
			public Point(int x, int y)
			{
				X = x;
				Y = y;
			}

			public int X { get; set; }
			public int Y { get; set; }
		}

		public void readFile()
		{
			using (StreamReader sr = new StreamReader(@"3.txt"))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					char[] array = line.ToCharArray();
					whichSite(array);
				}
				printPoints();
			}
		}

		public void addPoint(int x, int y)
		{
			points.Add(new Point(x, y));
			sum++;
		}

		public void checkPoint(int x , int y)
		{
			Point check = new Point(x,y);
			foreach (Point point in points)
			{
				if (point.Equals(check))
				{
					return;
				}
			}
			addPoint(x, y);
		}

		public void whichSite(char[] move)
		{
			addPoint(x, y);
			foreach (char step in move)
			{
				switch (step)
				{
					case '<':
						x -= 1;
						break;
					case '>':
						x += 1;
						break;
					case '^':
						y += 1;
						break;
					case 'v':
						y -= 1;
						break;
				}
				checkPoint(x,y);
			}
		}

		public void printPoints()
		{
			Console.WriteLine(sum);
		}
	}
}