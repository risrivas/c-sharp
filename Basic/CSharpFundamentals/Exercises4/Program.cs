using System;

namespace Exercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise4_1();
        }

        static void Exercise4_1()
        {
            Console.Write("enter few numbers separated by hyphen: ");
            var input = Console.ReadLine();
            var numbers = input.Split('-');
            var first = Convert.ToInt32(numbers[0]);

            var isConsecutive = true;

            for (var i = 1; i < numbers.Length; i++)
            {
                var number = Convert.ToInt32(numbers[i]);
                if ((number != (first + 1)) || (number != (first - 1)))
                {
                    isConsecutive = false;
                    break;
                }
                first = number;
            }

            if (isConsecutive)
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
