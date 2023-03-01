// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int A)
{
int sum = 0;
int i = 0;
i = A/1000 + A/100%10 + (A/10%10) + A%10;
{
sum += i; // sum = sum + i
}
return sum;
}

//Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма чисел {N} равна {GetSum(N)}");
