﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
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

string mnArray(int m, int n, int[,] inArray)
{
    if (m < 0 || n < 0) return "Введите m>0 и n>0";
    string result;
    bool Elements = m <= inArray.GetLength(0) - 1 && n <= inArray.GetLength(1) - 1;
    if (Elements)
    {
        result = $"{m},{n} -> {inArray[m, n]}";
    }
    else 
    {
        result = $"{m},{n} -> такого числа нет в массиве";
    }
    return result;
}

Console.Clear();

int rows = new Random().Next(5, 5);
int colums = new Random().Next(5, 5);
int[,] newArray = GetArray(rows, colums, -9, 9);
PrintArray(newArray);
Console.WriteLine();

Console.Write("Введите номер элемента: ");
int[] position = Array.ConvertAll(Console.ReadLine().Split(""), Convert.ToInt32);
int m = position[0], n = position[1];
Console.WriteLine(mnArray(m, n, newArray));