// Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

using System;

class Program
{
    static void Main()
    {
        // Создаем генератор случайных чисел
        Random random = new Random();

        // Создаем массив случайных целых чисел
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(-100, 100);
        }

        // Инициализируем переменные для хранения максимального и минимального элементов,
        // их индексов и суммы элементов массива
        int max = int.MinValue;
        int min = int.MaxValue;
        int maxIndex = -1;
        int minIndex = -1;
        int sum = 0;

        // Находим максимальный и минимальный элементы, их индексы и сумму элементов массива
        for (int i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];
            if (number > max)
            {
                max = number;
                maxIndex = i;
            }

            if (number < min)
            {
                min = number;
                minIndex = i;
            }

            sum += number;
        }

        // Вычисляем среднее арифметическое
        double average = (double)sum / numbers.Length;

        // Создаем массив для хранения информации о максимальном элементе, его индексе,
        // минимальном элементе, его индексе и среднем арифметическом
        object[] info = new object[5];
        info[0] = max;
        info[1] = maxIndex;
        info[2] = min;
        info[3] = minIndex;
        info[4] = average;

        // Выводим информацию
        Console.WriteLine("Исходный массив: [" + string.Join(", ", numbers) + "]");
        Console.WriteLine("Максимальный элемент: " + info[0] + ", индекс: " + info[1]);
        Console.WriteLine("Минимальный элемент: " + info[2] + ", индекс: " + info[3]);
        Console.WriteLine("Среднее арифметическое: " + info[4]);

        // Находим медианное значение первоначального массива
        Array.Sort(numbers);
        double median;
        if (numbers.Length % 2 == 0)
        {
            int middleIndex1 = numbers.Length / 2 - 1;
            int middleIndex2 = numbers.Length / 2;
            median = (numbers[middleIndex1] + numbers[middleIndex2]) / 2.0;
        }
        else
        {
            int middleIndex = numbers.Length / 2;
            median = numbers[middleIndex];
        }

        Console.WriteLine("Медианное значение: " + median);
    }
}
