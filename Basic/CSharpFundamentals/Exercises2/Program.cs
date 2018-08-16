using System;

namespace Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise2_2();
        }

        static void Exercise2_2()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("enter a number or \"ok\" to exit: ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input) || input.Equals("ok"))
                {
                    Console.WriteLine(sum);
                    break;
                }
                else
                {
                    sum += Convert.ToInt32(input);
                }
            }
        }

        static void Exercise2_1()
        {
            int count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) count++;
            }
            Console.WriteLine(count);
        }


    }
}
