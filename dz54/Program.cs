// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
// int[,] newArray = {{1, 4, 7 ,2}, {5, 9, 2, 3}, {8, 4, 2, 4},};  // строка для проверки
int[,] newArray = NewRandom2DArray(4, 5, -100, 101);
Print2DArray(newArray);
DegreeSortRowsArray(newArray);
Console.WriteLine();
Print2DArray(newArray);

////////////////////////

static void DegreeSortRowsArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int temp = 0; temp < array.GetLength(1); temp++)
        {
            for (int j = 0; j < array.GetLength(1) - temp - 1; j++)
            {
                if (array[i,j] < array[i,j+1])
                    Swap(ref array[i,j], ref array[i,j+1]);
            }
        }
    }
}

///////////////////////

static void Swap(ref int firstItem, ref int secondItem)
        {
            int temp = firstItem;
            firstItem = secondItem;
            secondItem = temp;
        } 

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