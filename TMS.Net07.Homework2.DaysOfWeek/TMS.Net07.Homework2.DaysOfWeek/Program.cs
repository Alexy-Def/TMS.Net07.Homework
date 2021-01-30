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
            DateTime maxDate = DateTime.Parse("31.12.2999");


            while (true)
            {
                Console.Write("Input wish date: ");

                wishDate = Console.ReadLine();
                parseDate = DateTime.Parse(wishDate);

                if (wishDate.ToLower() == "exit")
                {
                    Console.WriteLine();
                    Console.Write("Exiting the program...");
                    Thread.Sleep(1500);
                    Environment.Exit(0);
                }
                else if (parseDate <= maxDate)
                {
                    Console.Write("Day of week: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(parseDate.DayOfWeek);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Wrong date! Repeat, please...");
                    Console.WriteLine();
                }
            }
        }
    }
}