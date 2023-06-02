// Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4
// 000000 - > 1

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        double number = double.Parse(Console.ReadLine());

        int digitCount = CountDigits(number);

        Console.WriteLine("Количество цифр в числе: " + digitCount);
    }

    static int CountDigits(double number)
    {
        string numberString = number.ToString().Replace(".", "").Replace(",", "");
        return numberString.Length;
    }
}
