// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Summa(int num)
{
    int result = 0;
    for (int i=1; i<=num; i++)
        result+=i;
    return result;
}

void Summa2(int num)
{
    int result = 0;
    for (int i=1; i<=num; i++)
        result+=i;
    System.Console.WriteLine($"Сумма всех чисел от 1 до {num} равна {result}");
}


Console.Clear();
System.Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма всех чисел от 1 до {num} равна {Summa(num)}");
Summa2(num);