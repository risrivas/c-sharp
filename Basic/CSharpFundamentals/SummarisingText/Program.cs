﻿using System;

namespace SummarisingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really really long text.";
            Console.WriteLine(StringUtility.SummarizeText(sentence, 25));
        }


    }


}
