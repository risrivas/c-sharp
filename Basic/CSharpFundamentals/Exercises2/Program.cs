using System;

namespace Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise2_5();
        }

        static void Exercise2_5()
        {
            Console.Write("enter a series of numbers separated by comma: ");
            var input = Console.ReadLine();

            string[] numbers = input.Split(',');
            int max = int.MinValue;
            foreach (string number in numbers)
            {
                //int num = Convert.ToInt32(number);
                //if (num > max)
                //{
                //    max = num;
                //}
                max = Math.Max(max, Convert.ToInt32(number));
            }
            Console.WriteLine(max);
        }

        static void Exercise2_4()
        {
            var secretNumber = new Random().Next(1, 10);

            for (var i = 1; i <= 4; i++)
            {
                Console.Write("pick a random number between 1 and 10: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == secretNumber)
                {
                    Console.WriteLine("You won");
                    return;
                }
            }

            Console.WriteLine("You lose. Secret number is: " + secretNumber);

        }

        static void Exercise2_3()
        {
            int fact = 1;
            Console.Write("enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            int number = input;
            while (input >= 1)
            {
                fact *= input--;
            }
            Console.WriteLine($"{number}! = {fact}");

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
