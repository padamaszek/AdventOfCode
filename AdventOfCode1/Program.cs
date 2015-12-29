using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode1.Day1;
using AdventOfCode1.Day2;
using AdventOfCode1.Day3;
using AdventOfCode1.Day5;
using AdventOfCode1.Day6;

namespace AdventOfCode1
{
	class Program
	{
		static void Main(string[] args)
		{
			Advent1 adv1 = new Advent1();
			Advent2 adv2 = new Advent2();
			Advent3 adv3 = new Advent3();
			Advent32 adv32 = new Advent32();
			Advent5 adv5 = new Advent5();
			Advent52 adv52 = new Advent52();
			Advent6	adv6 = new Advent6();
			Advent62 adv62 = new Advent62();

			//adv1.ReadFile();
			//adv2.ReadFile();
			//adv3.ReadFile();
			//adv32.ReadFile();
			//adv5.ReadFile();
			//adv52.ReadFile();
			//adv6.ReadFile();
			adv62.ReadFile();

			Console.ReadKey();
		}
	}
}