using DotNetAdvancedTopics.Generics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DotNetAdvancedTopics.TypeCasting
{
    public class BoxingAndUnboxing
    {
        public void CallArrayListObject(ArrayList arrayList)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Array List output");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
            var questions = Questions();
            int index = 0;
            foreach (var item in arrayList)
            {
                Console.WriteLine(questions[index].ToString() + item);
                index++;
            }
            Console.WriteLine();
        }

        public void CallGenericsListObject(dynamic collection)
        {
            Console.WriteLine("Generics output");
            Console.WriteLine("----------------------------------");
            int index = 1;
            foreach (var item in collection.collection)
            {
                Console.WriteLine(index + "." + item);
                index++;
            }
        }

       public ArrayList AddArrayListItem()
       {
            ArrayList arrayList = new ArrayList();
            Console.WriteLine("                   Array List Example                    ");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Enter your name: string");
            arrayList.Add( Console.ReadLine());
            Console.WriteLine("Enter your age: int");
            arrayList.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter your salary: decimal");
            arrayList.Add(decimal.Parse(Console.ReadLine()));
            Console.WriteLine("Are you married:True or False: bool");
            arrayList.Add(Console.ReadLine());
            return arrayList;
        }

        public ArrayList Questions()
        {
            ArrayList questions = new ArrayList();
            questions.Add("Your Name : ");
            questions.Add("Your Age :");
            questions.Add("Your Salary : ");
            questions.Add("Are You Married :");
            return questions;
        }


        public dynamic AddGenericsListItem()
        {
            Console.WriteLine("                   Generic List Example                    ");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Select the datatype number you want add into Generic collection from the following");
            Console.WriteLine("1: String\n2: int\n3: Double\n4: Boolean");
            var inputType = int.Parse(Console.ReadLine());
            if (inputType == 1)
            {
                Console.WriteLine("Enter only names");
                Generics<string> Names = new Generics<string>();
                Names.Value = "String Object";
                Names.MyGenericMethod<string>("Jagadeesh");
                Console.WriteLine("How many names you want to enter");
                var noOfNames = int.Parse(Console.ReadLine());
                for (int i = 0; i < noOfNames; i++)
                {
                    Console.WriteLine("Enter " + (i + 1) + " name");
                    Names.AddItemToCollection(Console.ReadLine());
                }
                return Names;
            }
            else if (inputType == 2)
            {
                Console.WriteLine("Enter only numbers");
                Generics<int> Numbers = new Generics<int>();
                Numbers.Value = int.MinValue;
                Numbers.MyGenericMethod<int>(int.MaxValue);
                Console.WriteLine("How many numbers you want to enter");
                var numCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < numCount; i++)
                {
                    Console.WriteLine("Enter " + (i + 1) + " number");
                    Numbers.AddItemToCollection(int.Parse(Console.ReadLine()));
                }
                return Numbers;
            }
            else if (inputType == 3)
            {
                Console.WriteLine("Enter only numbers with decimal values");
                Generics<decimal> DecimalNumbers = new Generics<decimal>();
                DecimalNumbers.Value = decimal.MinValue;
                DecimalNumbers.MyGenericMethod<decimal>(decimal.MaxValue);
                Console.WriteLine("How many decimal numbers you want to enter");
                var decNumCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < decNumCount; i++)
                {
                    Console.WriteLine("Enter " + (i + 1) + " decimal number");
                    DecimalNumbers.AddItemToCollection(int.Parse(Console.ReadLine()));
                }
                return DecimalNumbers;
            }
            else if (inputType == 4)
            {
                Console.WriteLine("Enter only Tru or false");
                Generics<bool> BooleanValues = new Generics<bool>();
                BooleanValues.Value = true;
                BooleanValues.MyGenericMethod<bool>(false);
               
                Console.WriteLine("Are you single?");
                BooleanValues.AddItemToCollection(bool.Parse(Console.ReadLine()));
                return BooleanValues;
            }
            return null;
        }

        public void AddSpace()
        {
            Console.WriteLine();
        }
    }
}
