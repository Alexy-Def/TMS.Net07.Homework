using System;

namespace TMS.Net07.Homework4.Task4.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input a number to calculate a factorial: ");
                long inputNumber = 0;
                bool isTryInputNumber = false;

                do
                {
                    isTryInputNumber = long.TryParse(Console.ReadLine(), out inputNumber);

                    if (!isTryInputNumber)
                    {
                        Console.Write("Incorrect input. Repeat, please: ");
                    }
                }
                while (!isTryInputNumber);

                Console.WriteLine($"Result: {CalculateFibonacci(inputNumber)}");

                Console.WriteLine();
                Console.Write("Input anyting to continue or input \"exit\" for exit the program: ");
                string isRepeatCycle = Console.ReadLine().ToLower();

                if (isRepeatCycle == "exit")
                {
                    return;
                }

                Console.Clear();
            }
        }

        static long CalculateFibonacci(long number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            else if (number < 0)
            {
                return CalculateFibonacci(number + 2) - CalculateFibonacci(number + 1);
            }
            else
            {
                return CalculateFibonacci(number - 1) + CalculateFibonacci(number - 2);
            }
        }
    }
}
