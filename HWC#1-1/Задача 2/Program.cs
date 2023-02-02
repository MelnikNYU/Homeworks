// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b ");
int b = int.Parse(Console.ReadLine()!);
if (b > a)
{
    Console.WriteLine($"max={b}");
}
else
{
    Console.WriteLine($"max={a}");
}