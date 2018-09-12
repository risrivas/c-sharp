using System.Collections.Generic;

namespace SummarisingText
{
    public class StringUtility
    {
        public static string SummarizeText(string sentence, int maxLength = 20)
        {
            if (sentence.Length < maxLength)
            {
                return sentence;
            }

            // sentence.Substring(0, maxLength);
            var words = sentence.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength) break;
            }

            return string.Join(" ", summaryWords) + "...";
        }
    }
}
