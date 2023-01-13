// Задача 26: Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе

Console.Clear();
int num = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int digNumbers = GetDigNumbers(num);
Console.WriteLine($"{num} -> {digNumbers}");

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

int GetDigNumbers(int number)
{
    int dig = 0;
    while (number > 0)
    {
        number = number / 10;
        dig++;
    }
    return dig;
}