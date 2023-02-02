// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N ");
int N = int.Parse(Console.ReadLine()!);
int k = -N;
while (k <= N) 
{  if (k%2 == 0) 
   {
    Console.WriteLine($"{k} ");
   }
   k++;
   
}
