//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

using System;

class Program
{
    static void Main()
    {
        System.Console.WriteLine("Введите трёхзначное число");
        int number = int.Parse(Console.ReadLine());
        //получаем вторую цифру
        int secondDigit=(number/10%10);
        System.Console.WriteLine("Вторая цифра числа " + secondDigit);
    }
}
