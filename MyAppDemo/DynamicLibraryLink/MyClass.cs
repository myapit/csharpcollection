/*
 * Created by SharpDevelop.
 * Author : myapit
 * User: domokun
 * Date: 31/12/2019
 * Time: 3:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * Example code in MyAppDemo
 * 
 */
using System;
using System.Collections.Generic;

namespace DynamicLibraryLink
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class MyClass
	{
		
		public int addTwoNumber(int a, int b)
		{
			return a+b;
		}
		
		public int subTwoNumber(int a, int b)
		{
			return a-b;
		}
		
		public static int AddNum(int x, int y)
		{
			return x+y;
		}
		
	} // End Class MyClass
} // End Namespace