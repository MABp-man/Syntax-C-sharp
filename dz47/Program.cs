// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.

Console.Clear();
Console.Write("Для заполнения массива ");
int from = GetNumberFromUser("введите начало диапазона случайных чисел: ");
int to = GetNumberFromUser("введите конец диапазона случайных чисел: ");

double[,] newArray = NewRandom2DimensionArray(3, 4, from, to);
Print2DimensionArray(newArray);


////////////////////////
static double[,] NewRandom2DimensionArray(int rows, int columns, int from, int to)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array [i, j] = new Random().Next(from, to) + new Random().NextDouble();
        }
    }
    return array;
}

/////////////////////

static int GetNumberFromUser(string Welcome)
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

/////////////////////////

static void Print2DimensionArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
    }
}