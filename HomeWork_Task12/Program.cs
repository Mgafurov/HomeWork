// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

using System;

class Program
{
    static void Main()
    {
        System.Console.WriteLine("Введите цифру обозначающий день недели");
        int dayOfWeek = int.Parse(Console.ReadLine());
        //Проверяем является ли день выходным
        bool isWeekend = (dayOfWeek == 6) || (dayOfWeek == 7);

        if(isWeekend)
        {
            System.Console.WriteLine("Да это выходной день");
        }
        else
        {
            System.Console.WriteLine("Нет,это не выходной день");
        }
    }
}
