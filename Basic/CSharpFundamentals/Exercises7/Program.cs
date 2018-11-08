using System;

namespace Exercises7
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(4);
            stack.Push(6);
            stack.Push(14);
            stack.Push(19);
            stack.Push(32);

            stack.Display();

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Display();
        }
    }
}
