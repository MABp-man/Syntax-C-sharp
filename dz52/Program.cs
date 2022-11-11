// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
// int[,] newArray = {{1, 4, 7 ,2}, {5, 9, 2, 3}, {8, 4, 2, 4},};  // строка для проверки
int[,] newArray = NewRandom2DArray(4, 4, -100, 101);
Print2DArray(newArray);
double[] result = ArrayColumnAverage(newArray);
PrintResultArray("Среднее арифметическое каждого столбца: ", result);

////////////////////////
static int[,] NewRandom2DArray(int rows, int columns, int from, int to)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array [i, j] = new Random().Next(from, to);
        }
    }
    return array;
}

///////////////////////

static void Print2DArray(int[,] array)
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

//////////////////////

static double[] ArrayColumnAverage(int[,] array1)
{
    double[] resultArray = new double[array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array1.GetLength(0); j++)
        {
           sum += array1[j, i];
        }
        resultArray[i] = sum / array1.GetLength(0);
    }    
    return resultArray;
}

//////////////////////////

static void PrintResultArray(string message, double[] array2)
{
    Console.WriteLine();
    Console.Write(message);
    Console.WriteLine(string.Join(", ", array2));
}
