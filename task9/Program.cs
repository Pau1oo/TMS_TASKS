﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void showMenu()
    {
        Console.WriteLine("[1] Сложение");
        Console.WriteLine("[2] Вычитание");
        Console.WriteLine("[3] Деление");
        Console.WriteLine("[4] Умножение");
        Console.WriteLine("[5] Процент от числа");
        Console.WriteLine("[6] Квадратный корень числа");
        Console.WriteLine("[7] Выход");
    }

    public static double input()
    {
        double num;
        Console.WriteLine("Введите число:");
        while (!double.TryParse(Console.ReadLine(), out num))
        {
            Console.Clear();
            Console.WriteLine("Ошибка! Нажмите любую кнопку...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Введите число:");
        }
        Console.Clear();
        return num;
    }

    public delegate double Operation(double x, double y);

    public static double Add(double x, double y) => x + y;
    public static double Multiply(double x, double y) => x * y;
    public static double Substract(double x, double y) => x - y;
    public static double Division(double x, double y) => x / y;
    public static double Remainder(double x, double y) => x % y;
    public static double Sqrt(double x, double y) => Math.Sqrt(x);   

    public static double DoOperation(double x, double y, Operation operation)
    {
        return operation(x, y);
    }


    public static void Main()
    {
        int selection;
        var num = input();
        while (true)
        {
            Console.WriteLine($"Текущее значение: {Math.Round(num, 3)}");
            showMenu();

            while (!int.TryParse(Console.ReadLine(), out selection))
            {
                Console.Clear();
                Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"Текущее значение: {Math.Round(num, 3)}");
                showMenu();
            }

            switch (selection)
            {
                case 1:
                    Console.Clear();
                    var x = input();
                    num = DoOperation(num, x, Add);
                    break;
                case 2:
                    Console.Clear();
                    x = input();
                    num = DoOperation(num, x, Substract);
                    break;
                case 3:
                    Console.Clear();
                    x = input();
                    num = DoOperation(num, x, Division);
                    break;
                case 4:
                    Console.Clear();
                    x = input();
                    num = DoOperation(num, x, Multiply);
                    break;
                case 5:
                    Console.Clear();
                    x = input();
                    num = DoOperation(num, x, Remainder);
                    break;
                case 6:
                    Console.Clear();
                    num = DoOperation(num, num, Sqrt);
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
}

