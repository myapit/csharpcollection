/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 30/09/2019
 * Time: 2:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using DynamicLibraryLink;

namespace MyAppDemo
{
	class Program
	{
		public static void Main(string[] args)
		{
			MyClass me = new MyClass();
			Console.WriteLine("Hello World!");
			Console.WriteLine(me.addTwoNumber(100,200));
			// TODO: Implement Functionality Here
			
			Console.WriteLine(MyClass.AddNum(10,50));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}