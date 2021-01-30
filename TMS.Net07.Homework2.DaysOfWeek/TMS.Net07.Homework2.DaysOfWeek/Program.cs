using System;
using System.Threading;

namespace TMS.Net07.Homework2.DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string wishDate;
            DateTime parseDate;

            while (true)
            {
                Console.Write("Input wish date: ");

                wishDate = Console.ReadLine();

                if (wishDate.ToLower() == "exit")
                {
                    Console.WriteLine();
                    Console.Write("Exiting the program...");
                    Thread.Sleep(1500);
                    Environment.Exit(0);
                }

                parseDate = DateTime.Parse(wishDate);

                Console.Write("Day of week: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(parseDate.DayOfWeek);                
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}