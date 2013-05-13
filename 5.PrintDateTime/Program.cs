using System;
//Create a console application that prints the current date and time.

    class DateAndTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yy"+" "+"HH:mm:ss tt")); //Second Version
        }
    }
