using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetAdvancedTopics.ExceptionHandling
{
    public class CustomException : Exception
    {
        public CustomException() { }

        public override string Message => GetCustomMessage("an internal issue occured . Please try again");

        public string GetCustomMessage(string message)
        {
            return "Checked " + message;
        }
    }
}
