using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises4
{
    public class Exercises4Util
    {
        public static bool IsConsecutive(string[] numbers)
        {
            var first = Convert.ToInt32(numbers[0]);

            for (var i = 1; i < numbers.Length; i++)
            {
                var number = Convert.ToInt32(numbers[i]);
                if (!((number == (first + 1)) || (number == (first - 1))))
                {
                    return false;
                }
                first = number;
            }

            return true;
        }

        public static bool IsDuplicate(string[] numbers)
        {
            var set = new HashSet<string>();
            for (var i = 0; i < numbers.Length; i++)
            {
                var canAdd = set.Add(numbers[i]);
                if (!canAdd)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsValidTime(string[] time)
        {
            if (time.Length == 2)
            {
                var hours = Convert.ToInt32(time[0]);
                var minutes = Convert.ToInt32(time[1]);
                if ((hours >= 0 && hours <= 23) && (minutes >= 0 && minutes <= 59))
                {
                    return true;
                }
            }
            return false;
        }

        public static string ConvertToPascalCase(string[] words)
        {
            var builder = new StringBuilder();
            foreach (var word in words)
            {
                builder.Append(word.First().ToString().ToUpper() + word.Substring(1));
            }

            return builder.ToString();
        }

        public static int CountNumberOfVowels(string word)
        {
            var vowels = new HashSet<Char>();
            vowels.Add('a');
            vowels.Add('e');
            vowels.Add('i');
            vowels.Add('o');
            vowels.Add('u');

            var count = 0;
            foreach (var input in word.ToCharArray())
            {
                if (vowels.Contains(input))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
