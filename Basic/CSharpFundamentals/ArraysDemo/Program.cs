using System;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            // Clear
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            // Copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("\nEffect of Copy()");
            foreach (var n in another)
            {
                Console.Write(n + " ");
            }

            // Sort
            Array.Sort(numbers);

            Console.WriteLine("\nEffect of Sort()");
            foreach (var n in numbers)
            {
                Console.Write(n + " ");
            }

            // Reverse
            Array.Reverse(numbers);

            Console.WriteLine("\nEffect of Reverse()");
            foreach (var n in numbers)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();
        }
    }
}
