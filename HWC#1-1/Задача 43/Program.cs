// Задача 43: Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.Clear();

double NumX(int a1, int b1, int a2, int b2)
{
    double x1 = a2 - a1;
    double x2 = b1 - b2;
    double x = x1 / x2;
    return x;
}

double NumY(int b1, int a1, double x)
{
    double y = (b1 * x) + a1;
    return y;
}

Console.Write("Введите значение a1: ");
int a1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение a2: ");
int a2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine()!);

double x = NumX(a1, b1, a2, b2);
double y = NumY(b1, a1, x);

Console.Write($"a1 = {a1}, b1 = {b1}, a2 = {a2}, b1 = {b2} -> ({x}; {y}) ");