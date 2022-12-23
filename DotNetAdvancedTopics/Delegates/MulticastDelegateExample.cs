using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetAdvancedTopics.Delegates
{
    public static class MulticastDelegateExample
    {
		// declaring delegate
		public delegate void MultiCastDelegate(double height, double width);

		// "area" method
		public static void area(double height, double width)
		{
			Console.WriteLine("Invoking the square delegate for Area method with height: " + height + " width: " + width);
			Console.WriteLine("-------------------------------------------------------------------------------");

			Console.WriteLine("Area is: {0}", (width * height));
			Console.WriteLine();
			Console.WriteLine();
		}

		// "perimeter" method
		public static void perimeter(double height, double width)
		{
			Console.WriteLine("Invoking the square delegate for Perimeter method with height: " + height + " width: " + width);
			Console.WriteLine("--------------------------------------------------------------------------------------");

			Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
			Console.WriteLine();
		}


		// Main Method
		public static void CallMulticastDelegate()
		{

			// creating delegate object, name as "multiCastDelegate"
			// and pass the method as parameter by
			// class object "MulticastDelegateExample"
			MultiCastDelegate squareDelegate = new MultiCastDelegate(MulticastDelegateExample.area);

			// also can be written as
			// MultiCastDelegate multiCastDelegate = example.area;

			// call 2nd method "perimeter"
			// Multicasting
			squareDelegate += MulticastDelegateExample.perimeter;

			// pass the values in two method
			// by using "Invoke" method
			Console.WriteLine();
			Console.WriteLine("                                 Multi Cast Delegate Example                                 ");
			Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
			Console.WriteLine();


			Console.WriteLine("********Invoking the square delegate for calling the both Area and Perimeter methods********");

			Console.WriteLine();

			Console.WriteLine("Square Inputs");
			Console.WriteLine("--------------------");
			Console.WriteLine();


			Console.WriteLine("Enter square height");
			double height = double.Parse(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine("Enter square width");
			double width = double.Parse(Console.ReadLine());
			Console.WriteLine();

			

			squareDelegate.Invoke(height, width);
			Console.WriteLine();

		}
	}
}
