using System;
using System.Threading;

namespace Exercises6
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercises6_1();
        }

        static void Exercises6_1()
        {
            var stopWatch = new StopWatch();

            stopWatch.Start();
            Thread.Sleep(2000);
            stopWatch.Stop();

            Console.WriteLine(stopWatch.Duration().Seconds);
        }
    }
}
