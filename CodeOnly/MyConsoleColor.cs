using System;

class Program
{
	static void Main()
	{
		Random rand = new Random();
		Console.Title = "Random Color";
		while(true){
			switch (rand.Next(0,5)) {
				case 0:
					Console.BackgroundColor = ConsoleColor.White; break;	
				case 1:
					Console.BackgroundColor = ConsoleColor.Red; break;
				case 2:
					Console.BackgroundColor = ConsoleColor.Green; break;
				case 3:
					Console.BackgroundColor = ConsoleColor.Yellow; break;
				case 4:
					Console.BackgroundColor = ConsoleColor.Red; break;
			}
			Console.Write(" ");
			//Console.Beep(200,200);
		}
	}
}