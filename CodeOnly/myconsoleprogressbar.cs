using System;
using System.Threading;
using ProgressBar;

static class Program 
{
	//using namespace ProgressBar;
	static void Main() {
		Console.Write("Performing some task... ");
		using (ProgressBar progress = new ProgressBar()) {
			for (int i = 0; i <= 100; i++) {
				progress.Report((double) i / 100);
				Thread.Sleep(20);
			}
		}
		Console.WriteLine("Done.");
	}

}

