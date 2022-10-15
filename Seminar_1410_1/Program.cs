Console.Clear();
int N = NumberInput("Введите целое положительное число: ","Ошибка ввода!");
Console.WriteLine($"{N} => {GetSumN(N)}");
Console.WriteLine($"{N} => {GetDigitAmount(N)}");
Console.WriteLine($"{N} => {GetFactorialN(N)}");

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

///////////////////

static int GetDigitAmount(int N)
{
    int digitAmount = 1;
    for (; N > 9; N = N / 10, digitAmount++);
    return digitAmount;
}

/////////////////

static int GetFactorialN(int N)
{
    int factorialN = 1;
    for (int i = N; i > 1; i--)
    {
        factorialN = factorialN * i;
    }
    return factorialN;
}