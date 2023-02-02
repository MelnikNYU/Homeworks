//Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите число c ");
int c = int.Parse(Console.ReadLine()!);

if (b > a && b > c)
{
    Console.WriteLine($"max={b}");
}
else if (c > b)
{
    Console.WriteLine($"max={c}");
}
else
{
    Console.WriteLine($"max={a}");
}