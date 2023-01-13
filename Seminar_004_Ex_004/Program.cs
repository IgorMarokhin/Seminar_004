// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

Console.Clear();
GetArrayNumbers();

void GetArrayNumbers()
{
    Console.Write("[");
    for (int i = 0; i < 8; i++)
    {
        int number = new Random().Next(0,2);
        Console.Write($"{number}");
        if (i < 7) Console.Write(",");
    }
    Console.Write("]");
    Console.WriteLine();
}