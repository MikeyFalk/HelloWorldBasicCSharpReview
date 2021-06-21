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

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            
        }
    }
}
