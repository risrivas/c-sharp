using System;
using System.Collections.Generic;

namespace Exercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise3_1();
            // Exercise3_2();
            // Exercise3_3();
            // Exercise3_4();
            Exercise3_5();
        }

        static void Exercise3_5()
        {
            while (true)
            {
                Console.Write("enter a list of 5 comma separated numbers: ");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid list - please retry");
                    continue;
                }
                else
                {
                    var numbers = input.Split(',');
                    var list = new List<int>();
                    foreach (var num in numbers)
                    {
                        list.Add(Convert.ToInt32(num));
                    }
                    if (list.Count != 5)
                    {
                        Console.WriteLine("Invalid list - please retry");
                        continue;
                    }
                    else
                    {
                        list.Sort();
                        for (var i = 0; i < 3; i++)
                        {
                            Console.Write("{0} ", list[i]);
                        }
                        Console.WriteLine();
                        break;
                    }

                }
            }
        }

        static void Exercise3_4()
        {
            var set = new HashSet<string>();
            while (true)
            {
                Console.Write("enter a number or type \"Quit\" to quit: ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;
                else if (input.Equals("Quit")) break;
                else
                {
                    set.Add(input);
                }
            }
            foreach (var num in set)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }

        static void Exercise3_3()
        {
            var isUnique = false;
            while (!isUnique)
            {
                Console.Write("enter 5 unique numbers separated by space: ");
                string input = Console.ReadLine();
                var numbers = input.Split(" ".ToCharArray());
                var list = new List<int>();

                foreach (var number in numbers)
                {
                    var num = Convert.ToInt32(number);
                    if (list.Contains(num))
                    {
                        isUnique = false;
                        Console.WriteLine("you entered duplicate number {0}, please try again", num);
                        break;
                    }
                    else
                    {
                        isUnique = true;
                        list.Add(num);
                    }
                }

                if (isUnique)
                {
                    list.Sort();
                    Console.Write("sorted input list: ");
                    foreach (var n in list)
                    {
                        Console.Write("{0} ", n);
                    }
                    Console.WriteLine();
                }
            }

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
