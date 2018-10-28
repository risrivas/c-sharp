using System;
using System.Threading;

namespace Exercises6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercises6_1();
            Exercises6_2();
        }

        static void Exercises6_2()
        {
            var post = new Post()
            {
                Title = "StackOverflow Post",
                Description = "This post is similar to StackOverflow post",
                CreateDate = DateTime.Now
            };

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();

            post.DownVote();

            Console.WriteLine("Votes: {0}", post.GetVotes());
        }

        static void Exercises6_1()
        {
            var stopWatch = new StopWatch();

            stopWatch.Start();
            // stopWatch.Start();

            Thread.Sleep(2000);

            stopWatch.Stop();
            // stopWatch.Stop();

            Console.WriteLine(stopWatch.Duration().Seconds);
        }
    }
}
