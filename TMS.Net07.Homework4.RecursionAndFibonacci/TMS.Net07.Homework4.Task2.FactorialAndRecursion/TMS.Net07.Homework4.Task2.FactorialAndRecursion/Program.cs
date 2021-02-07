using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework4.Task2.FactorialAndRecursion
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

                Console.WriteLine($"Result: {CalculateFactorialWithRecursion(inputNumber)}");

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

        static ulong CalculateFactorialWithRecursion(ulong number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * CalculateFactorialWithRecursion(number - 1);
            }
        }
    }
}
