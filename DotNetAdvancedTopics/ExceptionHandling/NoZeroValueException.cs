using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetAdvancedTopics.ExceptionHandling
{
    public class NoZeroValueException: DivideByZeroException
    {
        public override string Message => GetCustomMessage("Zero is not acceptable");

        public string GetCustomMessage(string message)
        {
            return "Checked " + message;
        }
    }
}
