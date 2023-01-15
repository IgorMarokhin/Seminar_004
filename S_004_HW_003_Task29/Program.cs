// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.

Console.Clear();
GetArrayNumbers();

void GetArrayNumbers()
{
    Console.Write("[");
    for (int i = 0; i < 8; i++)
    {
        int number = new Random().Next();
        Console.Write($"{number}");
        if (i < 7) Console.Write(",");
    }
    Console.Write("]");
    Console.WriteLine();
}