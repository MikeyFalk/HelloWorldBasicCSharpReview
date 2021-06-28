using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldBasicCSharpReview
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName );
        }

        public static int Increment(int number)
        {
            return number += 10;

        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
