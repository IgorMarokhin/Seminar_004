// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
int numA = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int numB = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int degreeNumbers = GetDegreeNumbers(numA,numB);
Console.WriteLine($"{numA}, {numB} -> {degreeNumbers}");

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

int GetDegreeNumbers(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}