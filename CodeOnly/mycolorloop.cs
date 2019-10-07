using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
	static void Main()
	{
		Random rnd = new Random();
		Console.Title = "mycolor loop";
		
		while(true)
		{
			switch(rand.Next(0,4))
			{
				case 0: Console.BackgroundColor = ConsoleColor.White; break;
				case 1: Console.BackgroundColor = ConsoleColor.Red; break;
				case 2: Console.BackgroundColor = ConsoleColor.Green; break;
				case 3: Console.BackgroundColor = ConsoleColor.Yellow; break;
			}
			Console.Write (" ");
		}
		
	}
}