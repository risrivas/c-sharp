using System;
using System.IO;

namespace Exercises5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise5_1();
            Exercise5_2();
        }

        static void Exercise5_1()
        {
            var path = @"C:\Users\rishi\Downloads\info.txt";
            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);
                var words = content.Split(' ');
                Console.WriteLine("Total number of words in the file {0}: {1}", Path.GetFileName(path), words.Length);
            }
        }

        static void Exercise5_2()
        {
            var path = @"C:\Users\rishi\Downloads\info.txt";
            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);
                var words = content.Split(' ');
                var maxLength = 0;
                var longestWord = "";

                foreach (var word in words)
                {
                    var len = word.Length;
                    if (len > maxLength)
                    {
                        maxLength = len;
                        longestWord = word;
                    }
                }
                Console.WriteLine("Longest word in the file {0}: {1}", Path.GetFileName(path), longestWord);
            }

        }
    }
}
