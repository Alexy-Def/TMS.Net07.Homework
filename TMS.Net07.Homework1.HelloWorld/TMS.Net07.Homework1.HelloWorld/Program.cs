// Консольное приложение, которое выводит введенное пользователем число на экран, при этом запрашивая ввод следующего числа.
// При вводе 0, программа должна закрыться сама.

using System;
using System.Threading;

namespace TMS.Net07.Homework1.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            begin:
            Console.Write("Введите, пожалуйста, какое-нибудь число: ");
            string anyNumber = Console.ReadLine();
            Console.WriteLine();
            bool validation = int.TryParse(anyNumber, out int parseNumber);

            if (validation == true)
            {
                if (parseNumber == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("Из-за числа '0' программа вынуждена сама закрыться через несколько секунд...");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Отлично! Введенное Вами число является действительным. И оно равно {0}", parseNumber);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("К сожалению, скорее всего, Вы ввели не число.");
                Console.ResetColor();
            }

            Console.WriteLine();
            goto begin;
        }
    }
}
