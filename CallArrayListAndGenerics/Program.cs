using DotNetAdvancedTopics.TypeCasting;
using System;
using System.Collections;

namespace CallArrayListAndGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxingAndUnboxing boxingUnbox = new BoxingAndUnboxing();
            var arrayList = boxingUnbox.AddArrayListItem();
            var genericList = boxingUnbox.AddGenericsListItem();
            boxingUnbox.CallArrayListObject(arrayList);
            boxingUnbox.CallGenericsListObject(genericList);
            Console.WriteLine();
        }
    }
    
}
