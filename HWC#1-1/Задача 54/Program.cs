// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] GetArray(int r, int c, int minValue, int maxValue)
{
    int[,] array = new int[r, c];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void inArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int m = j + 1; m < array.GetLength(1); m++)
            {
                if (array[i, j] < array[i, m])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, m];
                    array[i, m] = temp; 
                }
            }
        }
    }
}

Console.Clear();

Console.Write("r = ");
int r = int.Parse(Console.ReadLine()!);

Console.Write("c = ");
int c = int.Parse(Console.ReadLine()!);

int[,] newArray = GetArray(r, c, -10, 10);
Console.WriteLine();
PrintArray(newArray);
inArray(newArray);
Console.WriteLine();
PrintArray(newArray);
