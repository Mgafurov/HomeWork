// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] numbers = new int[4];
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(-100, 100);
        }
        int sum = 0;
        for(int i = 1; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        System.Console.WriteLine("Исходный массив : ["+ string.Join(",", numbers) + "]");
        System.Console.WriteLine("Сумма элементов на нечётных позициях : " + sum);
    }
}