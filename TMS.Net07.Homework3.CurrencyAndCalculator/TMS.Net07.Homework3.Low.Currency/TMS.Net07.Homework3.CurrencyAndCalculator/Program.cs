using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework3.CurrencyAndCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal BuyUsdToByn = 2.6250m;
            const decimal SellUsdToByn = 2.6310m;
            const decimal BuyUsdToEur = 0.8252m;
            const decimal SellUsdToEur = 0.8315m;
            const decimal BuyUsdToRub = 75.5051m;
            const decimal SellUsdToRub = 76.9710m;

            const decimal BuyEurToByn = 3.1650m;
            const decimal SellEurToByn = 3.1680m;
            const decimal BuyEurToRub = 91.4940m;
            const decimal SellEurToRub = 94.6320m;

            const decimal BuyBynToRub = 28.8243m;
            const decimal SellBynToRub = 29.9132m;

            while (true)
            {
                Console.Write("Input currency FROM: ");
                string currencyFrom = Console.ReadLine().ToLower();

                Console.Write("Input currency TO: ");
                string currencyTo = Console.ReadLine().ToLower();

                Console.Write("Choice BUY/SELL: ");
                string buyOrSell = Console.ReadLine().ToLower();

                Console.Write("Input amount: ");
                bool isParseAmount = decimal.TryParse(Console.ReadLine(), out decimal currencyAmount);

                string incorrectlyInputCurrencyFrom = " ";
                string incorrectlyInputCurrencyTo = " ";
                string incorrectlyInputBuyOrSell = " ";
                bool isRightInputCurrency = true;
                decimal convertedAmount = 0;

                if (isParseAmount)
                {
                    if (buyOrSell == "buy")
                    {
                        switch (currencyFrom)
                        {
                            case "usd":
                                switch (currencyTo)
                                {
                                    case "eur":
                                        convertedAmount = currencyAmount * BuyUsdToEur;
                                        break;
                                    case "rub":
                                        convertedAmount = currencyAmount * BuyUsdToRub;
                                        break;
                                    case "byn":
                                        convertedAmount = currencyAmount * BuyUsdToByn;
                                        break;
                                    case "usd":
                                        convertedAmount = currencyAmount;
                                        break;
                                    default:
                                        incorrectlyInputCurrencyTo = "You don't correctly input currency TO.";
                                        isRightInputCurrency = false;
                                        break;
                                }
                                break;
                            case "eur":
                                switch (currencyTo)
                                {
                                    case "usd":
                                        convertedAmount = currencyAmount / BuyUsdToEur;
                                        break;
                                    case "rub":
                                        convertedAmount = currencyAmount * BuyEurToRub;
                                        break;
                                    case "byn":
                                        convertedAmount = currencyAmount * BuyEurToByn;
                                        break;
                                    case "eur":
                                        convertedAmount = currencyAmount;
                                        break;
                                    default:
                                        incorrectlyInputCurrencyTo = "You don't correctly input currency TO.";
                                        isRightInputCurrency = false;
                                        break;
                                }
                                break;
                            case "byn":
                                switch (currencyTo)
                                {
                                    case "eur":
                                        convertedAmount = currencyAmount / BuyEurToByn;
                                        break;
                                    case "rub":
                                        convertedAmount = currencyAmount * BuyBynToRub;
                                        break;
                                    case "usd":
                                        convertedAmount = currencyAmount / BuyUsdToByn;
                                        break;
                                    case "byn":
                                        convertedAmount = currencyAmount;
                                        break;
                                    default:
                                        incorrectlyInputCurrencyTo = "You don't correctly input currency TO.";
                                        isRightInputCurrency = false;
                                        break;
                                }
                                break;
                            case "rub":
                                switch (currencyTo)
                                {
                                    case "eur":
                                        convertedAmount = currencyAmount / BuyEurToRub;
                                        break;
                                    case "usd":
                                        convertedAmount = currencyAmount / BuyUsdToRub;
                                        break;
                                    case "byn":
                                        convertedAmount = currencyAmount / BuyBynToRub;
                                        break;
                                    case "rub":
                                        convertedAmount = currencyAmount;
                                        break;
                                    default:
                                        incorrectlyInputCurrencyTo = "You don't correctly input currency TO.";
                                        isRightInputCurrency = false;
                                        break;
                                }
                                break;
                            default:
                                incorrectlyInputCurrencyFrom = "You don't correctly input currency FROM.";
                                isRightInputCurrency = false;
                                break;
                        }
                    }
                    else if (buyOrSell == "sell")
                    {
                        switch (currencyFrom)
                        {
                            case "usd":
                                switch (currencyTo)
                                {
                                    case "eur":
                                        convertedAmount = currencyAmount * SellUsdToEur;
                                        break;
                                    case "rub":
                                        convertedAmount = currencyAmount * SellUsdToRub;
                                        break;
                                    case "byn":
                                        convertedAmount = currencyAmount * SellUsdToByn;
                                        break;
                                    case "usd":
                                        convertedAmount = currencyAmount;
                                        break;
                                    default:
                                        incorrectlyInputCurrencyTo = "You don't correctly input currency TO.";
                                        isRightInputCurrency = false;
                                        break;
                                }
                                break;
                            case "eur":
                                switch (currencyTo)
                                {
                                    case "usd":
                                        convertedAmount = currencyAmount / SellUsdToEur;
                                        break;
                                    case "rub":
                                        convertedAmount = currencyAmount * SellEurToRub;
                                        break;
                                    case "byn":
                                        convertedAmount = currencyAmount * SellEurToByn;
                                        break;
                                    case "eur":
                                        convertedAmount = currencyAmount;
                                        break;
                                    default:
                                        incorrectlyInputCurrencyTo = "You don't correctly input currency TO.";
                                        isRightInputCurrency = false;
                                        break;
                                }
                                break;
                            case "byn":
                                switch (currencyTo)
                                {
                                    case "eur":
                                        convertedAmount = currencyAmount / SellEurToByn;
                                        break;
                                    case "rub":
                                        convertedAmount = currencyAmount * SellBynToRub;
                                        break;
                                    case "usd":
                                        convertedAmount = currencyAmount / SellUsdToByn;
                                        break;
                                    case "byn":
                                        convertedAmount = currencyAmount;
                                        break;
                                    default:
                                        incorrectlyInputCurrencyTo = "You don't correctly input currency TO.";
                                        isRightInputCurrency = false;
                                        break;
                                }
                                break;
                            case "rub":
                                switch (currencyTo)
                                {
                                    case "eur":
                                        convertedAmount = currencyAmount / SellEurToRub;
                                        break;
                                    case "usd":
                                        convertedAmount = currencyAmount / SellUsdToRub;
                                        break;
                                    case "byn":
                                        convertedAmount = currencyAmount / SellBynToRub;
                                        break;
                                    case "rub":
                                        convertedAmount = currencyAmount;
                                        break;
                                    default:
                                        incorrectlyInputCurrencyTo = "You don't correctly input currency TO.";
                                        isRightInputCurrency = false;
                                        break;
                                }
                                break;
                            default:
                                incorrectlyInputCurrencyFrom = "You don't correctly input currency FROM.";
                                isRightInputCurrency = false;
                                break;
                        }
                    }
                    else
                    {
                        incorrectlyInputBuyOrSell = "You don't correctly input BUY/SELL.";
                        isRightInputCurrency = false;
                    }

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You don't correctly input currency amount.");
                    isRightInputCurrency = false;
                }

                if (isRightInputCurrency)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} {1} is equal {2} {3}", currencyAmount, currencyFrom, Math.Round(convertedAmount, 4), currencyTo);
                    Console.ResetColor();
                }

                if (incorrectlyInputCurrencyFrom != " ")
                {
                    Console.WriteLine();
                    Console.WriteLine(incorrectlyInputCurrencyFrom);
                }
                if (incorrectlyInputCurrencyTo != " ")
                {
                    Console.WriteLine();
                    Console.WriteLine(incorrectlyInputCurrencyTo);
                }
                if (incorrectlyInputBuyOrSell != " ")
                {
                    Console.WriteLine();
                    Console.WriteLine(incorrectlyInputBuyOrSell);
                }

                Console.WriteLine();
                Console.Write("Exit or Not: ");
                string exit = Console.ReadLine().ToLower();
                
                if (exit == "exit")
                {
                    return;
                }

                Console.Clear();
            }
        }
    }
}