using System;
using System.Text;

namespace MyConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "My Console Color";
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Testing");
			Console.ReadKey();
			Console.ResetColor();
		}
	}
}