using System;
using System.Threading;

namespace TMS.Net07.Homework2.DaysOfWeek
{
    enum DayOfWeek : byte
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input a date before 2100: ");
                string inputDate = Console.ReadLine(); // Inputted data

                if (inputDate.ToLower() == "exit")
                {
                    Console.WriteLine();
                    Console.Write("Exiting the program...");
                    Thread.Sleep(1500);
                    Environment.Exit(0);
                }

                string[] separateDate = inputDate.Split('.'); // Array of separated values of a date
                int inputDay = int.Parse(separateDate[0]); // A day inputted
                int inputMonth = int.Parse(separateDate[1]); // A month inputted
                int inputYear = int.Parse(separateDate[2]); // A year inputted

                int leapYear = inputYear / 4; // A preliminary leap years
                int notLeapYear = inputYear - leapYear; // A preliminary not leap years
                int daysInFullMonth; // All days in a inputted month
                int allDaysInDateInputted;

                int countDayOfWeek; // Number of day of week

                if (inputYear % 4 == 0)
                {
                    GetDaysInFullMonth(inputMonth, true, out daysInFullMonth); // Get days in entered months

                    allDaysInDateInputted = (leapYear - 1 + CountDifference(inputYear)) * 366 + (notLeapYear - CountDifference(inputYear)) * 365 + daysInFullMonth + inputDay;

                    countDayOfWeek = allDaysInDateInputted % 7;
                }
                else
                {
                    GetDaysInFullMonth(inputMonth, false, out daysInFullMonth);

                    allDaysInDateInputted = (leapYear + CountDifference(inputYear)) * 366 + (notLeapYear - 1 - CountDifference(inputYear)) * 365 + daysInFullMonth + inputDay;

                    countDayOfWeek = allDaysInDateInputted % 7;
                }

                Console.Write("Day of week: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine((DayOfWeek)countDayOfWeek);
                Console.WriteLine();
                Console.ResetColor();
            }
        }

        static int CountDifference(int tempYear) // This method counts a difference for leap and not leap years for right count leap years
        {
            int returnDifference = 0;
            if ((tempYear >= 1 && tempYear <= 99) || (tempYear >= 900 && tempYear <= 999) || (tempYear >= 1800 && tempYear <= 1899))
            {
                returnDifference = 0;
            }
            else if ((tempYear >= 100 && tempYear <= 199) || (tempYear >= 1000 && tempYear <= 1099) || (tempYear >= 1900 && tempYear <= 2099))
            {
                returnDifference = -1;
            }
            else if ((tempYear >= 200 && tempYear <= 299) || (tempYear >= 1100 && tempYear <= 1299))
            {
                returnDifference = -2;
            }
            else if ((tempYear >= 300 && tempYear <= 499) || (tempYear >= 1300 && tempYear <= 1399))
            {
                returnDifference = -3;
            }
            else if ((tempYear >= 500 && tempYear <= 599) || (tempYear >= 1400 && tempYear <= 1499))
            {
                returnDifference = -4;
            }
            else if ((tempYear >= 600 && tempYear <= 699) || (tempYear >= 1500 && tempYear <= 1699))
            {
                returnDifference = -5;
            }
            else if ((tempYear >= 700 && tempYear <= 899) || (tempYear >= 1700 && tempYear <= 1799))
            {
                returnDifference = -6;
            }

            return returnDifference;
        }

        static void GetDaysInFullMonth(int tempCountMonth, bool leapOrNotLeap, out int returnDaysInFullMonth)
        {
            byte[] daysInNotLeapYear = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; // Array of days in a not leap year
            byte[] daysInLeapYear = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; // Array of days in a leap year
            returnDaysInFullMonth = 0;

            if (!leapOrNotLeap)
            {
                for (int i = 0; i < tempCountMonth - 1; i++)
                {
                    returnDaysInFullMonth = returnDaysInFullMonth + daysInNotLeapYear[i];
                }
            }
            else
            {
                for (int i = 0; i < tempCountMonth - 1; i++)
                {
                    returnDaysInFullMonth = returnDaysInFullMonth + daysInLeapYear[i];
                }
            }
        }
    }
}