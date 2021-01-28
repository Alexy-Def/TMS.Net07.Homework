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
            int number = int.Parse(anyNumber);
            Console.WriteLine($"Введенное Вами число: {number}");
            Console.WriteLine();
            Console.WriteLine("...Нажмите любую клавишу для выхода из программы...");
            Console.ReadKey();
        }
    }
}
