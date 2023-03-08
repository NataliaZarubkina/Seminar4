int A = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");
int B = GetNumberFromUser("Введите целое число B: ", "Ошибка ввода!");

int powNumbers = GetPowNumbers(A, B);
Console.WriteLine($"{A} в степени {B} = {powNumbers}");

int GetPowNumbers(int A, int B)
{
    int count = 1;
    while (B > 0)
    {
        count *= A;
        B--;
    }
    return count;
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