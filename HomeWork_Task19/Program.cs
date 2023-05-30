// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(8);
        
        Console.WriteLine("Случайный массив из 0 и 1:");
        PrintArray(array);

        bool moreOnes = CountOnesGreaterThanZeros(array);
        Console.WriteLine("Больше ли единиц, чем нулей: " + moreOnes);
    }

    static int[] GenerateRandomArray(int length)
    {
        Random random = new Random();
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(2); // Генерируем случайное число 0 или 1
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }

    static bool CountOnesGreaterThanZeros(int[] array)
    {
        int onesCount = 0;
        int zerosCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 1)
            {
                onesCount++;
            }
            else if (array[i] == 0)
            {
                zerosCount++;
            }
        }

        return onesCount > zerosCount;
    }
}


