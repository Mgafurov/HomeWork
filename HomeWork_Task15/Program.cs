﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using System;

class Program
{
    static void Main()
    {
        System.Console.WriteLine("Введите число N :");
        int N = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Таблица кубков чисел");

        for (int i = 1; i <= N; i++)
        {
            int cube = i * i * i;
            Console.Write(cube);

            if (i != N)
            {
                Console.Write(",");
            }
        }
    }
}