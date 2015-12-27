using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

			adv1.readFile();
			adv2.readFile();
			adv3.readFile();
			adv32.readFile();
			adv5.readFile();
			adv52.readFile();

			Console.ReadKey();
		}
	}
}
