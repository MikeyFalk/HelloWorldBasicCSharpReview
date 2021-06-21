using System;


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


           

        }
    }
}
