// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void GetMinSumRow(int[,] inArray)
{
    int min = -100;
    int minRow = 1;
    int sumNum = 0;
    bool isStarted = false;

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sumNum += inArray[i, j];
        }
        if (!isStarted || sumNum < min)
        {
            isStarted = true;
            min = sumNum;
            minRow = i + 1;
        }

    }
    Console.WriteLine($"{minRow}");
}

Console.Clear();

Console.Write("r = ");
int r = int.Parse(Console.ReadLine()!);

Console.Write("c = ");
int c = int.Parse(Console.ReadLine()!);

int[,] newArray = GetArray(r, c, -10, 10);
Console.WriteLine();
PrintArray(newArray);
GetMinSumRow(newArray);
