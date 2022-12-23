using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetAdvancedTopics.Delegates
{
    public static class SingleCastDelegate
    {
        // Declaring the delegates
        // Here return type and parameter type should
        // be same as the return type and parameter type
        // of the two methods
        // "addnum" and "subnum" are two delegate names

        //Syntax: 
        //[modifier] delegate [return_type][delegate_name] ([parameter_list]);
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        // method "sum"
        public static void sum(int a, int b)
        {
            Console.WriteLine("Addition: "+ a +" + "+ b+" = " + (a + b));
        }

        // method "subtract"
        public static void subtract(int a, int b)
        {
            Console.WriteLine("Subtraction: "+ a +" - "+ b+" = " + (a - b));
        }

        // Main Method
        public static void CallSingleCastDelegate()
        {

            // creating object "obj" of class "SingleCastDelegate"
            //SingleCastDelegate obj = new SingleCastDelegate();

            // creating object of delegate, name as "del_obj1"
            // for method "sum" and "del_obj2" for method "subtract" &
            // pass the parameter as the two methods by class object "obj"
            // instantiating the delegates
            addnum additionDel = new addnum(SingleCastDelegate.sum);
            subnum subtractionDel = new subnum(SingleCastDelegate.subtract);

            // pass the values to the methods by delegate object
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                     Single Cast Delegate Example                                ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("****To understand the concept of single cast delegate with the help of addition and subtraction methods with 2 inputs******");
            
            Console.WriteLine();

            Console.WriteLine("Enter first value a:");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Addition Delegate");
            Console.WriteLine("---------------------");
            additionDel(a, b);
            Console.WriteLine();
            Console.WriteLine("Subtraction Delegate");
            Console.WriteLine("--------------------");
            subtractionDel(a, b);

        }
    }
}
