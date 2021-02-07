using System;

namespace TMS.Net07.Homework4.Task1.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input a number to calculate a factorial: ");
                ulong inputNumber = 0;
                bool isTryInputNumber = false;

                do
                {
                    isTryInputNumber = ulong.TryParse(Console.ReadLine(), out inputNumber);

                    if (isTryInputNumber == true)
                    {
                        if (inputNumber < 0)
                        {
                            isTryInputNumber = false;
                            Console.Write("Incorrect input. Repeat, please: ");
                        }
                    }
                    else
                    {
                        Console.Write("Incorrect input. Repeat, please: ");
                    }

                }
                while (isTryInputNumber == false);

                Console.WriteLine($"Result: {CalculateFactorial(inputNumber)}");

                Console.WriteLine();
                Console.Write("Input anyting to continue or input \"exit\" for exit the program");
                string isRepeatCycle = Console.ReadLine().ToLower();

                if (isRepeatCycle == "exit")
                {
                    return;
                }

                Console.Clear();
            }
        }

        static ulong CalculateFactorial(ulong number)
        {
            ulong result = 1;

            if (number == 0)
            {
                return 0;
            }
            else
            {
                for (ulong i = 1; i <= number; i++)
                {
                    result *= i;
                }
            }

            return result;
        }
    }
}
