// Написать программу, которая из имеющегося массива формирует массив 
//из элементов менее 3 символов.


// var elements = new string[] { "hello", "world", "2224", ":-)1" };
 
// string[] group = Array.FindAll(elements, element => element.Length < 4);

// foreach (var element in group) Console.WriteLine(element);
string[] array1 = new string[5] {":-)", "03", "hello", "world", "rrrr"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[i] = array1[i];
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);