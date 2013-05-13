using System;
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First ten numbers are...");
            byte x = 10;
            for (int y = 2; y < 2 + x; y++)//++ will increment the value of y by 1 until the operation is over
            {
                if (y % 2 == 0)
                    Console.Write(y + ",");
                else
                    Console.Write(y * (-1) + ",");
            }
        }
    }
