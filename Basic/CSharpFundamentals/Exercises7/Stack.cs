using System;
using System.Collections;

namespace Exercises7
{

    public class Stack
    {
        private readonly ArrayList stackList = new ArrayList();

        public void Push(object obj)
        {
            if (obj == null) throw new InvalidOperationException();
            stackList.Add(obj);
        }

        public object Pop()
        {
            int count = stackList.Count;
            if (count == 0) return null;

            var element = stackList[count - 1];
            stackList.RemoveAt(count - 1);

            return element;
        }

        public void Clear()
        {
            stackList.Clear();
        }

        public void Display()
        {
            foreach (object element in stackList)
            {
                Console.Write("{0}->", element);
            }
            Console.WriteLine();
        }

    }
}


