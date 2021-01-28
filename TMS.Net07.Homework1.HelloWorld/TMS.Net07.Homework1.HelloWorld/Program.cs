// Консольное приложение, которое выводит введенное пользователем число на экран

using System;

namespace TMS.Net07.Homework1.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите, пожалуйста, какое-нибудь число: ");
            string anyNumber = Console.ReadLine();
            Console.WriteLine();
            bool validation = int.TryParse(anyNumber, out int parseNumber);

            if (validation == true)
            {
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
            Console.WriteLine("...Нажмите любую клавишу для выхода из программы...");
            Console.ReadKey();
        }
    }
}
