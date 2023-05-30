// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты точки A:");
        double[] pointA = ReadCoordinates();

        Console.WriteLine("Введите координаты точки B:");
        double[] pointB = ReadCoordinates();

        double distance = CalculateDistance(pointA, pointB);

        Console.WriteLine($"Расстояние между точкой A и точкой B: {distance:F2}");
    }

    static double[] ReadCoordinates()
    {
        double[] coordinates = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Координата {i + 1}: ");
            coordinates[i] = double.Parse(Console.ReadLine());
        }

        return coordinates;
    }

    static double CalculateDistance(double[] pointA, double[] pointB)
    {
        double sumOfSquares = 0;

        for (int i = 0; i < 3; i++)
        {
            double difference = pointA[i] - pointB[i];
            sumOfSquares += difference * difference;
        }

        return Math.Sqrt(sumOfSquares);
    }
}
