// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// int num = int.Parse(Console.ReadLine ()!);
// int res = num % 100 / 10;

// Console.Write($"{res}");

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine ()!);
int a = num /10000;
int b = num / 1000 % 10;
while (num < 10000 || num > 99999)
{
    Console.Write("Введите пятизначное число: ");
    num = int.Parse(Console.ReadLine ()!);
}
if (a == num % 10 && b == num % 100 / 10)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}