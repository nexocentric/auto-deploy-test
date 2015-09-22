using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubeGoldbergProgram
{
	class RubeGoldbergProgram
	{
		static Random numberGenerator = new Random();

		static void Main(string[] args)
		{
			Console.WriteLine("This program does something simple in the most complicated way possible.");

			int randomNumberOne = GetRandomNumber();
			int randomNumberTwo = GetRandomNumber();
			Console.WriteLine("Let's start with the random number. [{0}]", randomNumberOne);

			Console.WriteLine("And let's use the random number. [{0}]", randomNumberTwo);

			Console.WriteLine("What can we do with these numbers?");

			Console.WriteLine("Press any key to continue.");
			Console.ReadLine();
		}

		static int GetRandomNumber()
		{
			return numberGenerator.Next();
		}
	}
}
