using System;
using System.Collections.Generic;

namespace Exercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise3_1();
            Exercise3_2();
        }

        static void Exercise3_2()
        {
            Console.Write("enter name: ");
            string input = Console.ReadLine();
            var ca = input.ToCharArray();
            Array.Reverse(ca);
            string reverse = new string(ca);
            Console.WriteLine("reversed name: {0}", reverse);
        }

        static void Exercise3_1()
        {
            var namesList = new List<string>();
            while (true)
            {
                Console.Write("enter name: ");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                namesList.Add(input.Trim());
            }

            var size = namesList.Count;
            if (size == 0) return;
            if (size == 1) Console.WriteLine("[{0}] likes your post.", namesList[0]);
            if (size == 2) Console.WriteLine("[{0}] and [{1}] like your post.", namesList[0], namesList[1]);
            else Console.WriteLine("[{0}], [{1}] and [{2}] others like your post.", namesList[0], namesList[1], size - 2);
        }
    }
}
