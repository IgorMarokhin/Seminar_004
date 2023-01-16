// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.

/* Console.Clear();
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
} */

// Вариант решения 2. Додумался не сам.

/* Console.Clear();
int[] array = new int[8];
Random random = new Random();
Decision(array);
PrintArray(array);
Console.Write($" -> ");
PrintArray2(array);

//===================Methods=========================

void Decision(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        array[i] = random.Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
        if (i < count - 1)
            Console.Write(", ");
    }
}

void PrintArray2(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
        if (i < count - 1)
            Console.Write(", ");
    }
    Console.Write("]");
    Console.WriteLine();
} */

// Вариант решения 3. Додумался не сам.

/* Console.Clear();
int[] array = new int[8];

GetNumberFromUser("Введите целое число: ", "Ошибка ввода!", array);
PrintArray(array);
Console.Write($" -> ");
PrintArray2(array);

//===================Methods=========================

void GetNumberFromUser(string message, string errorMessage, int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        int userNumber = 0;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out userNumber))
                break;
            Console.WriteLine(errorMessage);
        }
        array[i] = userNumber;
    }

}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
        if (i < count - 1)
            Console.Write(", ");
    }
}

void PrintArray2(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
        if (i < count - 1)
            Console.Write(", ");
    }
    Console.Write("]");
    Console.WriteLine();
} */

// Решение с разбора на сеимнаре.

int[] array = GetRandomArray(8, 0, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");

/////////////////////////////////////////////

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    var rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
    }

    return result;
}