﻿using System;
using HelloWorldBasicCSharpReview.Math;


namespace HelloWorldBasicCSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //VariableExamples();

            /*
            // These are common types in C#.... 
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mike";
            bool isWorking = true;
            var newNumber = 13;

            number = 3;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(newNumber);
            */

            // A const cannot be changed after it is declared 
            // const float Pi = 3.14f;


            // This is an example of placeholders using format strings...
            /*
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            */

            // This is an example of type conversion there is no compile time error because an int is larger than a byte so it is an implicit type conversion
            /*
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            */
            // for this to work we need to cast the type conversion with an explicit type conversion

            /*
            int c = 3;
            byte d = c;

            Console.WriteLine(d);
            */
            /*
            // This is an example of an explicit type conversion using with `(byte)` max value for a byte is 255 so casting 1000 would result in 233.
            
            int c = 3;
            byte d = (byte)c;

            Console.WriteLine(d);
           */
            //casting cannot not work for changing all data types a string to an int must be done with the convert class

            /*
            var number = "1234";
            int iTwo = Convert.ToInt32(number);

            Console.WriteLine(iTwo);
            */

            //Example of a try Catch Block to find handle exception
            /*
             try
             {
                 var number = "1234";
                 byte b = Convert.ToByte(number);
                 Console.WriteLine(b);

             }
             catch(Exception)
             {
                 Console.WriteLine("the number could not be converted to a byte.");

             }
            */
            /*
            var a = 1;
            var b = 2;
            var c = 3;
            
            //These are arithmetic operators like you would see in a math equation 
            
            Console.WriteLine(a + b);
            Console.WriteLine(a / b);
            Console.WriteLine((float)a + (float)b);
            Console.WriteLine(a + b);
            
            // C# has the same order of operations as mathematical equations
            
            Console.WriteLine(a + b * c);
            
            // These are comparison operators. The result is either true or false
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            //This is possible but it is poor coding because it is confusing instead of a double negative you should use a positive to get the same result
            Console.WriteLine(!(a != b));

            //These are Logical Operators

            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b && c == a);
            Console.WriteLine(c > b || c == a);

            //This is possible but it is poor coding because it is confusing instead of a double negative you should use a positive to get the same result
            Console.WriteLine(!(c > b || c == a));
            */


            var mike = new Person();
            mike.FirstName = "Mike";
            mike.LastName = "Falk";
            mike.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine("This is the result of the calculator.Add method: " + result );

            Console.WriteLine();
            Console.WriteLine("This is the section on arrays: ");
            Console.WriteLine();
            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine();
            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine("This is what the bool array looks like: ");
            Console.WriteLine();
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            //This is an example of an array created with the object initialization syntax. 
            var names = new string[3] { "jack", "john", "mary" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

            Console.WriteLine();
            Console.WriteLine("This is the section for the strings demo");
            Console.WriteLine();

            var realFirstName = "Mike";
            var realLastName = "Falk";
            var myName = "Mikey";

            var fullName = realFirstName + " " + realLastName;

            var myFullName = string.Format("My name is {0} {1}", realFirstName, realLastName);

            var realNames = new string[3] { "john", "jack", "mary" };
            var formatNames = string.Join(",", names);
            Console.WriteLine(formatNames);


            // This is an example of a verbatim string

            var text = @"Hi John
Look into the following paths
c:\\folder1\\folder2
c:\\folder3\\folder4";
            Console.WriteLine(text);





        }
    }
}
