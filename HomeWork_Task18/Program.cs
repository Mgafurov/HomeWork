// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        int product = CalculateProduct(n);
        System.Console.WriteLine("Произведение чисел от 1 до N: " + product);
    }

    static int CalculateProduct(int n)
    {
        int product = 1;
        for(int i =1; i<= n; i++)
        {
            product *= i;
        }
        return product;
    }
}