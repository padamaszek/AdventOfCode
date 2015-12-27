using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1
{
	class Advent32
	{

		List<Point> points = new List<Point>();
		List<Point> Robopoints = new List<Point>();
		ArrayList robot = new ArrayList();
		ArrayList santa = new ArrayList();

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
					robotOrSanta(array);
				}
				printPoints();
			}
		}

		public void robotOrSanta(char[] array)
		{
			int len = array.Length;
			for (int i = 0; i < len; i++)
			{
				if (i%2 == 0)
				{
					robot.Add(array[i]);
				}
				else
				{
					santa.Add(array[i]);
				}
			}
			whichSite(robot);
			whichSite(santa);
		}

		public void addPoint(int x, int y)
		{
			sum++;
			points.Add(new Point(x, y));
		}

		public void checkPoint(int x, int y)
		{
			Point check = new Point(x, y);
			foreach (Point point in points)
			{
				if (point.Equals(check))
				{
					return;
				}
			}
			addPoint(x, y);
		}

		public void whichSite(ArrayList move)
		{
			x = 0;
			y = 0;
			checkPoint(x, y);
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
				checkPoint(x, y);
			}
		}

		public void printPoints()
		{
			Console.WriteLine(sum);
		}
	}
}