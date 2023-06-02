// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

using System;

class Program
{
    static void Main()
    {
        // Создаем генератор случайных чисел
        Random random = new Random();

        // Создаем массив и заполняем его случайными положительными трехзначными числами
        int[] numbers = new int[4];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000);
        }

        // Подсчитываем количество четных чисел в массиве
        int evenCount = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        // Выводим результат
        Console.WriteLine("Исходный массив: [" + string.Join(", ", numbers) + "]");
        Console.WriteLine("Количество четных чисел: " + evenCount);
    }
}
