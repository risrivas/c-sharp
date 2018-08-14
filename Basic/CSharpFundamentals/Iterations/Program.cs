using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            var name = "John Smith";
            foreach (var c in name)
            {
                Console.WriteLine(c);
            }

            var numbers = new int[] { 1, 2, 3, 4, 5 };
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                else
                {
                    break;
                }

            }
        }
    }
}
