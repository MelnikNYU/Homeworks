﻿// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
int[] GetArray(int size, int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int NumberArray(int[] array)
{
    int result = 0;
    foreach (int elements in array) //for (int i = 0; i < array.Length; i++)
    {
        if (elements % 2 == 0) result++; //if (array[i] % 2 == 0) result++;
    }
    return result;
}

int[] array = GetArray(4, 100, 1000);
Console.Write(String.Join(", ", array));

int result = NumberArray(array);
Console.Write($" -> {result}");
