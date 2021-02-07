using System;

namespace TMS.Net07.Homework3.Middle.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(90, 30);

            decimal firstNumber;
            decimal secondNumber;

            bool isTryFirstNumber = true;
            bool isTrySecondNumber = true;
            bool isTryCalcOperation = false;

            bool isOneSymbolInString = true;
            string inputCalcOperation = "";
            string calcOperations = "+-*/%";

            bool cycleRepeat = true;
            while (cycleRepeat)
            {
                isTryCalcOperation = false;
                isOneSymbolInString = true;

                Console.Write("Please, input the first number: ");
                do
                {
                    isTryFirstNumber = decimal.TryParse(Console.ReadLine(), out firstNumber);

                    if (isTryFirstNumber == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[ Error! ] ");
                        Console.ResetColor();
                        Console.Write("Please, input correct the first number: ");
                    }
                }
                while (isTryFirstNumber == false);

                Console.WriteLine();
                Console.Write("Please, input the second number: ");
                do
                {
                    isTrySecondNumber = decimal.TryParse(Console.ReadLine(), out secondNumber);

                    if (isTrySecondNumber == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[ Error! ] ");
                        Console.ResetColor();
                        Console.Write("Please, input correct the second number: ");
                    }
                }
                while (isTrySecondNumber == false);

                Console.WriteLine();
                Console.Write("Please, input calculation operator: ");
                do
                {
                    while (isOneSymbolInString)
                    {
                        inputCalcOperation = Console.ReadLine();
                        if (inputCalcOperation.Length == 1)
                        {
                            isOneSymbolInString = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[ Error! ] ");
                            Console.ResetColor();
                            Console.Write("You didn't correct inputted. You should input 1 symbol. Try again: ");
                        }
                    }

                    for (int i = 0; i < calcOperations.Length; i++)
                    {
                        if (calcOperations[i] == inputCalcOperation[0])
                        {
                            isTryCalcOperation = true;
                        }
                    }

                    if (isTryCalcOperation == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[ Error! ] ");
                        Console.ResetColor();
                        Console.Write("Input the correct calculation operator: ");
                        isOneSymbolInString = true;
                    }
                }
                while (isTryCalcOperation == false);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Calculation result: {CalcResult(firstNumber, secondNumber, inputCalcOperation)}");
                Console.ResetColor();
                Console.WriteLine();

                Console.Write("Input any symbol or press ENTER for continue or input \"exit\" for exit the program: ");
                string isRepeatCycle = Console.ReadLine().ToLower();

                if (isRepeatCycle == "exit")
                {
                    return;
                }

                Console.Clear();
            }
        }

        static decimal CalcResult(decimal firstNumber, decimal secondNumber, string inputCalcOperation)
        {
            decimal result = 0;

            switch (inputCalcOperation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    result = firstNumber % secondNumber;
                    break;
            }
            return result;
        }
    }
}