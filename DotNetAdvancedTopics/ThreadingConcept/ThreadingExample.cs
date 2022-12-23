using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DotNetAdvancedTopics.ThreadingConcept
{
    public static class ThreadingExample
    {
        
        public static async Task<int> ShowMethod()
        {
            int iValue = 0;
            Thread.Sleep(100);
            for (int i = 0; i < 10; i++)
            {
                    
                Console.WriteLine("Show method excecuting at " + (i +1)+ " time");
                iValue = i;
            }
            return iValue;
        }

         static void PutThreadSleep()
        {
            Thread.Sleep(5000);
        }

        async static Task PutTaskDelay()
        {
            await Task.Delay(5000);
        }

        public static async Task<int> DisplayMethod()
        {
            int iValue = 0;
            Thread.Sleep(50);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Display method excecuting at " + (i+1) + " time");
                iValue = i;
            }
            return iValue;
        }
    }
}
