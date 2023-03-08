int length = GetNumberFromUser("Введите длину массива: ", "Ошибка ввода!");
int min = GetNumberFromUser("Введите начальное значение диапазона: ", "Ошибка ввода!");
int max = GetNumberFromUser("Введите конечное значение диапазона: ", "Ошибка ввода!");
int[] array = FillArray(length, min, max);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] FillArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}