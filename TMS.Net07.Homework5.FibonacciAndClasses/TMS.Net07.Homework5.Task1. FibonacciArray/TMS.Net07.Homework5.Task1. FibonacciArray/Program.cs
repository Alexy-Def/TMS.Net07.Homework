using System;

namespace TMS.Net07.Homework5.Task1.FibonacciArray
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input number for Fibonacci calculation: ");
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

                long[] arrayFibonacciNumbers = new long[inputNumber + 1];

                long result = CalculateFibonacciIteration(inputNumber, arrayFibonacciNumbers);

                if ((isNumberBelowZero == true) && (inputNumber % 2 == 0))
                {
                    result *= -1;

                    for (long i = 0; i < arrayFibonacciNumbers.Length; i++)   // If inputted number <0 , so need to multiply by -1 those terms that are divisible by 2 without a remainder
                    {
                        if (i % 2 == 0)
                        {
                            arrayFibonacciNumbers[i] *= -1;
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Calculated the {0}th member is {1}", inputNumber, arrayFibonacciNumbers[inputNumber]);

                Console.WriteLine();
                Console.WriteLine("Array of Fibonacci numbers:");

                for (long i = 0; i < inputNumber + 1; i++)
                {
                    Console.Write("{0} ", arrayFibonacciNumbers[i]);
                }

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

        static long CalculateFibonacciIteration(long number, long[] arrayFibonacciNumbers)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }

            if (arrayFibonacciNumbers[number] == 0)
            {
                arrayFibonacciNumbers[number] = CalculateFibonacciIteration(number - 2, arrayFibonacciNumbers) + CalculateFibonacciIteration(number - 1, arrayFibonacciNumbers);
            }

            return arrayFibonacciNumbers[number];
        }
    }
}
