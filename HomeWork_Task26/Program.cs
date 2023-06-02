// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

using System;

class Program
{
    static void Main()
    {
        double[] numbers = {3.14, -2.5, 10.8, 5.2, 7.9};
        double max = double.MinValue;
        double min = double.MaxValue;
        foreach(double number in numbers)
        {
            if(number>max)
            {
                max=number;
            }
            if(number<min)
            {
                min=number;
            }
        }
        double diffence = max - min;
        System.Console.WriteLine("Исходный массив: ["+string.Join(",", numbers)+"]");
        System.Console.WriteLine("Максимальный элемент" + max);
        System.Console.WriteLine("Минимальный элемент" +  min);
        System.Console.WriteLine("Разница между максимальным и минимальным элементами :" + diffence);
    }
}