// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

using System;

class Program
{
    static void Main()
    {
        System.Console.WriteLine("Введите пятизначное число");
        int number = int.Parse(Console.ReadLine());

        //проверка на длину числа
        if (number < 10000 || number > 99999)
        {
            System.Console.WriteLine("Число не является пятизначным");
            return;
        }
        //разделение числа на отдельные цифры
        int digit1 = number / 10000;
        int digit2 = (number / 1000) % 10;
        int digit3 = (number / 100) % 10;
        int digit4 = (number / 10) % 10;
        int digit5 = number % 10;
        //проверка на палиндром
        if (digit1 == digit5 && digit2 == digit4)
        {
            System.Console.WriteLine("Да число является палиндромом");
        }
        else
        {
            System.Console.WriteLine("нет число не является палиндромом");
        }
    }
}