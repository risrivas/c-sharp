using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            int i2 = 1;
            byte b2 = (byte)i2;
            Console.WriteLine(b2);

            int i3 = 1000;
            byte b3 = (byte)i3;
            Console.WriteLine(b3);
            Console.WriteLine(1000 % 256);

            try
            {
                var number = "1234";
                int i4 = Convert.ToInt32(number);
                Console.WriteLine(i4);
                byte b4 = Convert.ToByte(number);
                Console.WriteLine(b4);

            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            try
            {
                string str5 = "true";
                bool b5 = Convert.ToBoolean(str5);
                Console.WriteLine(b5);
            }
            catch (Exception)
            {
                Console.WriteLine("The str could not be converted to a bool.");
            }
        }
    }
}
