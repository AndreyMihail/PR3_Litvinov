﻿namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            bool isA = false;
            bool isB = false;

            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Ввести А");
                Console.WriteLine("2. Ввести В");
                Console.WriteLine("3. Выполнить операцию \"+\"");
                Console.WriteLine("4. Выполнить операцию \"-\"");
                Console.WriteLine("5. Выполнить операцию \"*\"");
                Console.WriteLine("6. Выполнить операцию \"/\"");
                Console.WriteLine("0. Выход");

                Console.Write("Выберите пункт меню: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите значение А: ");
                        a = double.Parse(Console.ReadLine());
                        isA = true;
                        break;
                    case "2":
                        Console.Write("Введите значение В: ");
                        b = double.Parse(Console.ReadLine());
                        isB = true;
                        break;
                    case "3":
                        if (isA && isB)
                        {
                            Console.WriteLine($"Результат: {a} + {b} = {a + b}");
                        }
                        else
                        {
                            Console.WriteLine("Пожалуйста, введите значения А и В перед выполнением операции.");
                        }
                        break;
                    case "4":
                        if (isA && isB)
                        {
                            Console.WriteLine($"Результат: {a} - {b} = {a - b}");
                        }
                        else
                        {
                            Console.WriteLine("Пожалуйста, введите значения А и В перед выполнением операции.");
                        }
                        break;
                    case "5":
                        if (isA && isB)
                        {
                            Console.WriteLine($"Результат: {a} * {b} = {a * b}");
                        }
                        else
                        {
                            Console.WriteLine("Пожалуйста, введите значения А и В перед выполнением операции.");
                        }
                        break;
                    case "6":
                        if (isA && isB)
                        {
                            if (b != 0)
                            {
                                Console.WriteLine($"Результат: {a} / {b} = {a / b}");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: деление на ноль!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Пожалуйста, введите значения А и В перед выполнением операции.");
                        }
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте еще раз.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}