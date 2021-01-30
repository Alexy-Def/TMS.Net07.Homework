using System;
using System.Threading;

namespace TMS.Net07.Homework2.DaysOfWeek
{
    class Program
    {
        enum DaysOfWeekToRus
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье,
        }

        enum DaysOfWeekToEng
        {
            Monday,
            Tuesday,
            Wednsday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }

        static void Main(string[] args)
        {
            bool repeatCycle = true; // Confirmation continue
            while (repeatCycle)
            {
                Console.Write("Выберите язык, с которого будем переводить? [Eng] - Англ. / [Rus] - Русский: ");
                string language = Console.ReadLine(); // Choice of language for translate
                string day; // Day of week for translate
                string returnTranslate; // Confirmation of translate
                string backToChoiceLanguage; // Question about return to choice of language

                if (language.ToLower() == "eng")
                {
                    while (repeatCycle)
                    {
                        Console.Write("Введите день недели на английском: ");
                        day = Console.ReadLine();

                        switch (day.ToLower())
                        {
                            case "monday":
                                Console.WriteLine("В переводе на русский: {0}", (DaysOfWeekToRus)0);
                                break;
                            case "tuesday":
                                Console.WriteLine("В переводе на русский: {0}", (DaysOfWeekToRus)1);
                                break;
                            case "wednsday":
                                Console.WriteLine("В переводе на русский: {0}", (DaysOfWeekToRus)2);
                                break;
                            case "thursday":
                                Console.WriteLine("В переводе на русский: {0}", (DaysOfWeekToRus)3);
                                break;
                            case "friday":
                                Console.WriteLine("В переводе на русский: {0}", (DaysOfWeekToRus)4);
                                break;
                            case "saturday":
                                Console.WriteLine("В переводе на русский: {0}", (DaysOfWeekToRus)5);
                                break;
                            case "sunday":
                                Console.WriteLine("В переводе на русский: {0}", (DaysOfWeekToRus)6);
                                break;
                            case "exit":
                                Console.WriteLine();
                                Console.Write("Выхожу из программы...");
                                Thread.Sleep(1500);
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Такого дня недели не существует");
                                break;
                        }

                        Console.WriteLine();
                        Console.Write("Желаете продолжить перевод с ENG на RUS? ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("[Y] - Да ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("/ ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[N] - Нет");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        
                        returnTranslate = Console.ReadLine();

                        if (returnTranslate.ToLower() == "y")
                        {
                            repeatCycle = true;
                            Console.WriteLine();
                        }
                        else
                        {
                            repeatCycle = false;
                        }
                    }
                }
                else
                {
                    while (repeatCycle)
                    {
                        Console.Write("Enter a day of the week in Russian: ");
                        day = Console.ReadLine();

                        switch (day.ToLower())
                        {
                            case "понедельник":
                                Console.WriteLine("Translated into English: {0}", (DaysOfWeekToEng)0);
                                break;
                            case "вторник":
                                Console.WriteLine("Translated into English: {0}", (DaysOfWeekToEng)1);
                                break;
                            case "среда":
                                Console.WriteLine("Translated into English: {0}", (DaysOfWeekToEng)2);
                                break;
                            case "четверг":
                                Console.WriteLine("Translated into English: {0}", (DaysOfWeekToEng)3);
                                break;
                            case "пятница":
                                Console.WriteLine("Translated into English: {0}", (DaysOfWeekToEng)4);
                                break;
                            case "суббота":
                                Console.WriteLine("Translated into English: {0}", (DaysOfWeekToEng)5);
                                break;
                            case "воскресенье":
                                Console.WriteLine("Translated into English: {0}", (DaysOfWeekToEng)6);
                                break;
                            case "exit":
                                Console.WriteLine();
                                Console.Write("Exiting the program...");
                                Thread.Sleep(1500);
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("There is no such day of the week");
                                break;
                        }

                        Console.WriteLine();
                        Console.Write("Would you continue translate from RUS to ENG? ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("[Да] - Yes ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("/ ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[Нет] - No");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        returnTranslate = Console.ReadLine();

                        if (returnTranslate.ToLower() == "да")
                        {
                            repeatCycle = true;
                            Console.WriteLine();
                        }
                        else
                        {
                            repeatCycle = false;
                        }


                    }
                }

                Console.WriteLine();
                Console.Write("Вернуться к выбору языка для перевода? ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("[Y] - Да / [N] - Нет");
                Console.ForegroundColor = ConsoleColor.Gray;

                backToChoiceLanguage = Console.ReadLine();

                if (backToChoiceLanguage.ToLower() == "y")
                {
                    repeatCycle = true;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Выхожу из программы...");
                    Thread.Sleep(1500);
                    Environment.Exit(0);
                }
            }
        }
    }
}