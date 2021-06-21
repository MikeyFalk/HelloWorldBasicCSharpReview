using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldBasicCSharpReview
{
    class Variables
    {
        public void VariableExamples()
        {
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

        }
    }
}
