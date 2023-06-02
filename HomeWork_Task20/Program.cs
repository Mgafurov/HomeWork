//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Math.Pow юзать нельзя.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Введите число A");
        int A = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Введите степень B");
        int B = int.Parse(Console.ReadLine());
        int result = Power(A,B);
        System.Console.WriteLine("Результат" + result);
    }
    static int Power(int baseNumber, int exponent)
    {
        int result = 1;
        for(int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }
        return result;
    }
}