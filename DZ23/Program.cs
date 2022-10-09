Console.Clear();
int N = NumberInput("Введите целое число: ");
PrintCubes(N);

/////////////////////

static int NumberInput(string Welcome)
{
int N;
while (true)
{
    Console.WriteLine(Welcome);
    if(int.TryParse(Console.ReadLine(), out N)) break;
    Console.Clear();
    Console.WriteLine("Ошибка ввода!");
}
return N;
}
/////////////////

static void PrintCubes(int N)
{
    Console.Write($"{N} -> ");
    for (int i = 1; i < N; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
    }
    Console.Write(Math.Pow(N, 3));
}
