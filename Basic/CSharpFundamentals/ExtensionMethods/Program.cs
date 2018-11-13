using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post blah blah blah....";
            Console.WriteLine(post.Shorten(5));

            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18 };
            Console.WriteLine(numbers.Max());
        }
    }
}
