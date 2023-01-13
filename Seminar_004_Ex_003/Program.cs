// Задача 28: Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

Console.Clear();
int num = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int prodNumbers = GetProdNumbers(num);
Console.WriteLine($"{num} -> {prodNumbers}");

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
    Console.WriteLine(errorMessage);
    }
}

int GetProdNumbers(int number)
{
    int prod = 1;
    for (int i = 1; i <= num; i++)
    {
        prod *= i;
    }
    return prod;
}