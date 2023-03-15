// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

string NumberRec (int M)
{
if(M == 1) return $"{M}";
return $"{M}, " + NumberRec (M-1);
}
Console.Write("Введите число M = ");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine(NumberRec(M));