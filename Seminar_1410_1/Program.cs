Console.Clear();
int N = NumberInput("Введите целое положительное число: ","Ошибка ввода!");
Console.WriteLine($"{N} => {GetSumN(N)}");

/////////////////////

static int NumberInput(string WelcomeMessage, string ErrorMessage)
{
    while (true)
    {
        Console.WriteLine(WelcomeMessage);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userN);
        if (isCorrect)
          return userN;
        Console.Clear();
        Console.WriteLine(ErrorMessage);
    }
}
/////////////////

static int GetSumN(int N)
{
    int sumN = 0;
    for (int i = N; i > 0; i--)
    {
        sumN = sumN + i;
    }
    return sumN;
}