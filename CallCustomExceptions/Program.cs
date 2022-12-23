using DotNetAdvancedTopics.ExceptionHandling;
using System;

namespace CallCustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            try
            {
                checked
                {
                    if (x > 9)
                    {
                        throw new CustomException();
                    }
                }
            }
            catch(CustomException exf)
            {
                Console.WriteLine(exf.Message);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                Console.WriteLine("Finally Block excecuted after error thrown");
            }

        }

        
    }
}
