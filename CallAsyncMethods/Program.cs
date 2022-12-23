using DotNetAdvancedTopics.ThreadingConcept;
using System;

namespace CallAsyncMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadingExample.ShowMethod();
            CallAsyncDisplayMethod();
        }
        async static void CallAsyncDisplayMethod()
        {
            await ThreadingExample.DisplayMethod();
        }
    
    }
}
