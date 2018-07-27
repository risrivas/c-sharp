using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;

            Console.WriteLine(a + b);
            Console.WriteLine((float)a / b);

            Console.WriteLine(1 + 2 * 3);

            Console.WriteLine(1 > 2);
        }
    }
}
