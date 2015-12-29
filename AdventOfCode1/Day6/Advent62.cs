using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1.Day6
{
	class Advent62
	{
		int[,] grid = new int[1000, 1000];


		public void ReadFile()
		{
			using (StreamReader sr = new StreamReader(@"6.txt"))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					char[] array = line.ToCharArray();
					SplitLine(line);
				}
				PrintGrid();
			}
		}

		private void SplitLine(string line)
		{
			string[] splitted = line.Split(' ');
			string[] beginPoints;
			string[] endingPoints;
			int firstDimStart;
			int secondDimStart;
			int firstDimEnd;
			int secondDimEnd;

			switch (splitted[0])
			{
				case "turn":
					beginPoints = splitted[2].Split(',');
					endingPoints = splitted[4].Split(',');
					firstDimStart = Convert.ToInt32(beginPoints[0]);
					secondDimStart = Convert.ToInt32(beginPoints[1]);
					firstDimEnd = Convert.ToInt32(endingPoints[0]);
					secondDimEnd = Convert.ToInt32(endingPoints[1]);
					if (splitted[1] == "on")
					{
						TurnOn(firstDimStart, secondDimStart, firstDimEnd, secondDimEnd);
					}
					else
					{
						TurnOff(firstDimStart, secondDimStart, firstDimEnd, secondDimEnd);
					}
					break;
				case "toggle":
					beginPoints = splitted[1].Split(',');
					endingPoints = splitted[3].Split(',');
					firstDimStart = Convert.ToInt32(beginPoints[0]);
					secondDimStart = Convert.ToInt32(beginPoints[1]);
					firstDimEnd = Convert.ToInt32(endingPoints[0]);
					secondDimEnd = Convert.ToInt32(endingPoints[1]);
					Toggle(firstDimStart, secondDimStart, firstDimEnd, secondDimEnd);
					break;
			}
		}

		private void TurnOn(int firstDimStart, int secondDimStart, int firstDimEnd, int secondDimEnd)
		{
			for (int i = firstDimStart; i <= firstDimEnd; i++)
			{
				for (int j = secondDimStart; j <= secondDimEnd; j++)
				{
					grid[i, j] += 1;
				}
			}
		}

		private void TurnOff(int firstDimStart, int secondDimStart, int firstDimEnd, int secondDimEnd)
		{
			for (int i = firstDimStart; i <= firstDimEnd; i++)
			{
				for (int j = secondDimStart; j <= secondDimEnd; j++)
				{
					if (grid[i, j] <= 0)
					{
						continue;
					}
					grid[i, j] -= 1;
				}
			}
		}

		private void Toggle(int firstDimStart, int secondDimStart, int firstDimEnd, int secondDimEnd)
		{
			for (int i = firstDimStart; i <= firstDimEnd; i++)
			{
				for (int j = secondDimStart; j <= secondDimEnd; j++)
				{
					grid[i, j] += 2;
				}
			}
		}

		private void PrintGrid()
		{
			int sum = 0;
			foreach (int i in grid)
			{
				sum = sum + i;
			}
			Console.WriteLine(sum);
		}
	}
}