static void PrintSquares(int N)
{
    Console.Write($"{N} -> ");
    for (int i = 1; i < N; i++)
    {
        Console.Write($"{i*i}, ");
    }
    Console.Write(N*N);
}

/////////////////////////

int N;
while (true)
{
    Console.WriteLine("Введите целое число: ");
    if(int.TryParse(Console.ReadLine(), out N)) break;
    Console.WriteLine("Ошибка ввода!");
}

PrintSquares(N);