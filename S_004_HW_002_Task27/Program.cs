// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.

Console.Clear();
int num = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int sumCountNumber = GetSumCountNumber(num);
Console.WriteLine($"{num} -> {sumCountNumber}");

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

int GetSumCountNumber(int num)
{
    int count = Convert.ToString(num).Length;
    int result = 0;
    int sum = 0;

    for (int i = 0; i < count; i++)
    {
        result = num - num % 10;
        sum = sum + (num - result);
        num = num / 10;
    }
    return sum;
}