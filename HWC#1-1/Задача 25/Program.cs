// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//Math.Pow( x , y );

Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine ()!);

Console.Write("Введите y: ");
double y = double.Parse(Console.ReadLine ()!);

double pow = Math.Pow(x,y);

Console.Write($"{pow} ");