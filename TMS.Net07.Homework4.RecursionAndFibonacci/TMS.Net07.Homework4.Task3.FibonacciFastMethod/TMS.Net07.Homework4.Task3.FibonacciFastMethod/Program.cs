using System;

namespace TMS.Net07.Homework4.Task3.FibonacciFastMethod
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

                    if (isTryInputNumber == false)
                    {
                        Console.Write("Incorrect input. Repeat, please: ");
                    }
                }
                while (isTryInputNumber == false);

                bool isNumberBelowZero = false;

                if (inputNumber < 0)   // If inputted number <0 , so need to multiply number on -1 to make the calculation more simple.
                {
                    inputNumber *= -1;
                    isNumberBelowZero = true;
                }

                long result = CalculateFibonacciIteration(inputNumber);

                if ((isNumberBelowZero == true) && (inputNumber % 2 == 0))
                {
                    result *= -1;
                }

                Console.WriteLine($"Result: {result}");

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

        static long CalculateFibonacciIteration(long number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }

            long prePreviousNumber = 0;
            long previousNumber = 1;
            long currentNumber = 1;

            for (long i = 2; i < number; i++)
            {
                prePreviousNumber = previousNumber + currentNumber;
                previousNumber = currentNumber;
                currentNumber = prePreviousNumber;
            }

            return currentNumber;
        }
    }
}
