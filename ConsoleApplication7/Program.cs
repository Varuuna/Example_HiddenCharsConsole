using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
	class Program
	{
		static void Main(string[] args)
		{
			string pass = "";
			Console.Write("Enter your password: ");
			ConsoleKeyInfo key;

			do
			{
				key = Console.ReadKey(true);

				// Backspace Should Not Work
				if (key.Key != ConsoleKey.Backspace)
				{
					pass += key.KeyChar;
					Console.Write("");
				}
				else
				{
					Console.Write("\b");
				}
			}
			// Stops Receving Keys Once Enter is Pressed
			while (key.Key != ConsoleKey.Enter);

			Console.WriteLine();
			Console.WriteLine("The Password You entered is : " + pass);
			Console.ReadKey();
		}
	}
}
