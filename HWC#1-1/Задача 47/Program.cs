﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(minValue + new Random().NextDouble() * (maxValue - minValue), 1);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}
Console.Clear();

Console.Write("Введите цифры в строки: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите цифры в столбцы: ");
int colums = int.Parse(Console.ReadLine()!);

double[,] newArray = GetArray(rows, colums, -9.9, 9.9);
Console.WriteLine();
PrintArray(newArray);
