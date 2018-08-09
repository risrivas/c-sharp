using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine($"a: {a} b: {b}");

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[1] = 0;
            Console.WriteLine($"array1[1]: {array1[1]} array2[1]: {array2[1]}");

            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person()
            {
                Age = 10
            };

            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        private static void MakeOld(Person person)
        {
            person.Age += 10;
        }

        private static void Increment(int number)
        {
            number += 10;
        }
    }

    class Person
    {
        public int Age;
    }
}
