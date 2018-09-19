using System;

namespace Exercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise4_1();
            //Exercise4_2();
            //Exercise4_3();
            //Exercise4_4();
            Exercise4_5();
        }

        static void Exercise4_5()
        {
            Console.Write("enter a word: ");
            var input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                var word = input.ToLower();
                Console.WriteLine(Exercises4Util.CountNumberOfVowels(word));
            }
        }

        static void Exercise4_4()
        {
            Console.Write("enter few words separated by space: ");
            var input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                var words = input.ToLower().Split(' ');
                Console.WriteLine(Exercises4Util.ConvertToPascalCase(words));
            }
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
