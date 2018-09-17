using System;

namespace Exercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise4_1();
            //Exercise4_2();
            Exercise4_3();
        }

        static void Exercise4_3()
        {
            Console.Write("enter a time value in the 24-hour format (e.g. 19:00) - ");
            var input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                var time = input.Split(':');

                if (Exercises4Util.IsValidTime(time))
                {
                    Console.WriteLine("Ok");
                    return;
                }
            }
            Console.WriteLine("Invalid time");
        }

        static void Exercise4_2()
        {
            Console.Write("enter few numbers separated by hyphen: ");
            var input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                var numbers = input.Split('-');

                if (Exercises4Util.IsDuplicate(numbers))
                {
                    Console.WriteLine("Duplicate");
                }
            }

        }

        static void Exercise4_1()
        {
            Console.Write("enter few numbers separated by hyphen: ");
            var input = Console.ReadLine();
            var numbers = input.Split('-');

            if (Exercises4Util.IsConsecutive(numbers))
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }
    }
}
