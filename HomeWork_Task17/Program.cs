// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        int digitCount = input.Length;
        Console.WriteLine("Количество цифр в числе: " + digitCount);
    }
}
