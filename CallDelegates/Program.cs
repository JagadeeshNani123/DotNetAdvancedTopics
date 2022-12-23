using DotNetAdvancedTopics.Delegates;
using System;

namespace CallDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            Console.WriteLine("Date value: "+ date);
            SingleCastDelegate.CallSingleCastDelegate();
            Console.WriteLine();
            MulticastDelegateExample.CallMulticastDelegate();
        }
    }
}
