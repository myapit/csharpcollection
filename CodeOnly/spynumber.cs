//spynumber .. product and sum is equal
//author: myapit

using System;

namespace SpyNumber
{
	class Run
	{
		// boolean function to 
		// check Spy number 
		static bool checkSpy(int input) 
		{ 

			int digit, sum = 0, 
				product = 1; 
			while (input > 0) 
			{ 
				digit = input % 10; 

				// getting the sum 
				// of digits 
				sum += digit; 

				// getting the product 
				// of digits 
				product *= digit; 
				input = input / 10; 
			} 

			// Comparing the sum 
			// and product 
			if (sum == product) 
				return true; 
			else
				return false; 
		} 
		
		public static void Main(string[] args)
		{
			string number;
			Console.Write("Enter an integer number :");
			number = Console.ReadLine();
			int input = Int32.Parse(number);
			if (checkSpy(input)) 
				Console.WriteLine("The number is a Spy number"); 
			else
				Console.WriteLine("The number is NOT a Spy number"); 
		}//end main
	}//end class
}//end namespace
