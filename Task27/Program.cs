int num = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");
int numDigit = CountDigit(num);
Console.WriteLine($"{num} -> {numDigit}");

int CountDigit(int num)
{
    int result = 0;
    while (num != 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}