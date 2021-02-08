using System;

namespace TextCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrCalcUn = { "sqrt", "sqr", "cos", "sin" };
            string[] arrCalcBin = { "pow", "+", "-", "*", "/", "%", "plus", "minus", "multiply", "x", "X", "divide" };

            int indexOfSubstring = 0;
            string mathOper = "";
            bool isArrCalcUn = true;
            string inputString = "";


            bool isTryInput = true;

            string argAfterMathOperString = "";
            double argAfterMathOperDouble = 0;
            string argBeforeMathOperString = "";
            double argBeforeMathOperDouble = 0;
            bool isTryParseArg = true;

            while (true)
            {
                indexOfSubstring = 0;
                mathOper = "";
                isArrCalcUn = true;
                inputString = "";

                isTryInput = true;

                argAfterMathOperString = "";
                argAfterMathOperDouble = 0;
                argBeforeMathOperString = "";
                argBeforeMathOperDouble = 0;
                isTryParseArg = true;

                Console.Write("Input wish calculation: ");
                do
                {
                    inputString = Console.ReadLine().Trim();

                    for (int i = 0; i < arrCalcUn.Length; i++)
                    {
                        indexOfSubstring = inputString.IndexOf(arrCalcUn[i]);
                        if (indexOfSubstring == 0)
                        {
                            mathOper = arrCalcUn[i];
                            isArrCalcUn = true;
                            isTryInput = false;
                            break;
                        }
                    }

                    if (indexOfSubstring == -1)
                    {
                        for (int i = 0; i < arrCalcBin.Length; i++)
                        {
                            indexOfSubstring = inputString.IndexOf(arrCalcBin[i]);
                            if ((indexOfSubstring != -1) && (indexOfSubstring != 0))
                            {
                                mathOper = arrCalcBin[i];
                                isArrCalcUn = false;
                                isTryInput = false;
                                break;
                            }
                        }
                    }

                    if (indexOfSubstring == -1)
                    {
                        Console.Write("Error. Wrong math operator! Repeat, please: ");
                        continue;
                    }

                    switch (isArrCalcUn)
                    {
                        case true:
                            argAfterMathOperString = inputString.Substring(indexOfSubstring + mathOper.Length, inputString.Length - mathOper.Length);
                            isTryParseArg = double.TryParse(argAfterMathOperString, out argAfterMathOperDouble);

                            if (!isTryParseArg)
                            {
                                Console.Write("Else one error. Wrong argument! Repeat, please: ");
                                isTryInput = true;
                                continue;
                            }
                            break;
                        default:
                            argBeforeMathOperString = inputString.Substring(0, indexOfSubstring);
                            isTryParseArg = double.TryParse(argBeforeMathOperString, out argBeforeMathOperDouble);

                            if (!isTryParseArg)
                            {
                                Console.Write("Else one error. Wrong the first argument! Repeat, please: ");
                                isTryInput = true;
                                continue;
                            }

                            argAfterMathOperString = inputString.Substring(indexOfSubstring + mathOper.Length, inputString.Length - mathOper.Length - indexOfSubstring);
                            isTryParseArg = double.TryParse(argAfterMathOperString, out argAfterMathOperDouble);

                            if (!isTryParseArg)
                            {
                                Console.Write("Else one error. Wrong the second argument! Repeat, please: ");
                                isTryInput = true;
                                continue;
                            }
                            break;
                    }

                }
                while (isTryInput);

                CalculationResult(mathOper, argBeforeMathOperDouble, argAfterMathOperDouble);

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

        static void CalculationResult(string mathOper, double argBeforeMathOperDouble, double argAfterMathOperDouble)
        {
            double result = 0;

            switch (mathOper)
            {
                case "sqr":
                    result = argAfterMathOperDouble * argAfterMathOperDouble;
                    Console.WriteLine("Result: {0}", result);
                    break;
                case "sqrt":
                    if (argAfterMathOperDouble >= 0)
                    {
                        result = Math.Sqrt(argAfterMathOperDouble);
                        Console.WriteLine("Result: {0}", result);
                    }
                    else
                    {
                        Console.WriteLine("No! No! No! It is wrong. Argument should be >= 0");
                    }
                    break;
                case "cos":
                    if ((argAfterMathOperDouble >= 0) && (argAfterMathOperDouble <= 360))
                    {
                        double radian = (argAfterMathOperDouble * Math.PI) / 180;
                        result = Math.Cos(radian);
                        Console.WriteLine("Result: {0}", result);
                    }
                    else
                    {
                        Console.WriteLine("No! No! No! It is wrong. Argument should be >= 0 and <= 360");
                    }
                    break;
                case "sin":
                    if ((argAfterMathOperDouble >= 0) && (argAfterMathOperDouble <= 360))
                    {
                        double radian = (argAfterMathOperDouble * Math.PI) / 180;
                        result = Math.Sin(radian);
                        Console.WriteLine("Result: {0}", result);
                    }
                    else
                    {
                        Console.WriteLine("No! No! No! It is wrong. Argument should be >= 0 and <= 360");
                    }
                    break;
                case "pow":
                    result = Math.Pow(argBeforeMathOperDouble, argAfterMathOperDouble);
                    Console.WriteLine("Result: {0}", result);
                    break;
                case "+":
                    result = argBeforeMathOperDouble + argAfterMathOperDouble;
                    Console.WriteLine("Result: {0}", result);
                    break;
                case "plus":
                    result = argBeforeMathOperDouble + argAfterMathOperDouble;
                    Console.WriteLine("Result: {0}", result);
                    break;
                case "-":
                    result = argBeforeMathOperDouble - argAfterMathOperDouble;
                    Console.WriteLine("Result: {0}", result);
                    break;
                case "minus":
                    result = argBeforeMathOperDouble - argAfterMathOperDouble;
                    Console.WriteLine("Result: {0}", result);
                    break;
                case "*":
                    result = argBeforeMathOperDouble * argAfterMathOperDouble;
                    Console.WriteLine("Result: {0}", result);
                    break;
                case "multiply":
                    result = argBeforeMathOperDouble * argAfterMathOperDouble;
                    Console.WriteLine("Result: {0}", result);
                    break;
                case "x":
                    result = argBeforeMathOperDouble * argAfterMathOperDouble;
                    Console.WriteLine("Result: {0}", result);
                    break;
                case "X":
                    result = argBeforeMathOperDouble * argAfterMathOperDouble;
                    Console.WriteLine("Result: {0}", result);
                    break;
                case "/":
                    result = argBeforeMathOperDouble / argAfterMathOperDouble;
                    Console.WriteLine("Result: {0}", result);
                    break;
                case "divide":
                    result = argBeforeMathOperDouble / argAfterMathOperDouble;
                    Console.WriteLine("Result: {0}", result);
                    break;
                default:
                    result = argBeforeMathOperDouble % argAfterMathOperDouble;
                    Console.WriteLine("Result: {0}", result);
                    break;
            }
        }
    }
}
