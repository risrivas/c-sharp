using System;

namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1_4();
        }

        static void Exercise1_4()
        {
            Console.WriteLine("enter the speed limit: ");
            try
            {
                int speedLimit = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the speed of the car: ");
                int speedCar = int.Parse(Console.ReadLine());
                if (speedCar < speedLimit)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    int demeritPoints = (speedCar - speedLimit) / 5;
                    if (demeritPoints > 12)
                        Console.WriteLine("License suspended");
                    else
                        Console.WriteLine($"Demerit points: {demeritPoints}");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
        }

        static void Exercise1_3()
        {
            Console.WriteLine("enter the width: ");
            try
            {
                int width = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the height: ");
                int height = int.Parse(Console.ReadLine());
                string orientation = (width >= height) ? "landscape" : "portrait";

                Console.WriteLine($"Orientation is {orientation}");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }

        }

        static void Exercise1_2()
        {
            Console.WriteLine("enter first number: ");
            try
            {
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("enter second number: ");
                int secondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine($"Larger number is {Math.Max(firstNumber, secondNumber)}");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }

        }

        static void Exercise1_1()
        {
            Console.WriteLine("enter a number: ");
            try
            {
                int userIput = int.Parse(Console.ReadLine());
                if (userIput >= 1 && userIput <= 10)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
