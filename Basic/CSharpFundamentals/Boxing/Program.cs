using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Today);

            var anotherList = new List<int>();
            anotherList.Add(1);

            var names = new List<string>();
            names.Add("Mosh");

        }
    }
}
