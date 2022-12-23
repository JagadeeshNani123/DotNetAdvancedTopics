using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetAdvancedTopics.NullableObjects
{
    public class NullableReferenceTypes
    {
        public NullableReferenceTypes()
        {
            Console.WriteLine("Checking for Integer Values");
            Console.WriteLine("Before making Null with Nullable Keyword");
            Nullable<int> integerWithNullableKeyWord = 0;
            Console.WriteLine(" X value: "+ integerWithNullableKeyWord);
            Console.WriteLine("After making  Null with Nullable Keyword");
            integerWithNullableKeyWord = null;
            Console.WriteLine(" X value: " + integerWithNullableKeyWord);

            Console.WriteLine("Before making Null with ?");
            int? integerWithQuestionMark = 0;
            Console.WriteLine(" X value: " + integerWithQuestionMark);
            Console.WriteLine("After making  Null with ?");
            integerWithQuestionMark = null;
            Console.WriteLine(" X value: " + integerWithQuestionMark);

        }
    }
}
