using System;
//Write a program to read your age from the console and print how old you will be after 10 years.

    class AfterTenYears
    {
        static void Main(string[] args)
        {
            int x;
            {
                Console.WriteLine("Enter Your Current Age");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine((x+10)+" "+"will be yours age after ten years");
            }
        }
    }
