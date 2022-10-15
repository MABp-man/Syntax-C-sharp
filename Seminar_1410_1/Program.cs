Console.Clear();
int N = NumberInput("Введите целое положительное число: ","Ошибка ввода!");
Console.WriteLine($"{N} => {GetSumN(N)}");
Console.WriteLine($"{N} => {GetDigitAmount(N)}");
Console.WriteLine($"{N} => {GetFactorialN(N)}");
Console.WriteLine(ArrayRandom01());

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
///////////////////////

static string ArrayRandom01()
{
    int[] Array01 = new int[8];
    for (int i = 0; i < 8; i++)
    {
        Array01[i] = new Random().Next(0,2);
    }
    string array01 = string.Join(",", Array01);

    return array01;
}