// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
// int[,] newArray1 = {{2, 4}, {3, 2}};  // строка для проверки
// int[,] newArray2 = {{3, 4}, {3, 3}};  // строка для проверки
int[,] newArray1 = NewRandom2DArray(3, 2, -10, 11);
int[,] newArray2 = NewRandom2DArray(2, 3, -10, 11);
Print2DArray(newArray1);
Console.WriteLine();
Print2DArray(newArray2);
int[,] productArray = GetProductArray(newArray1, newArray2);
Console.WriteLine();
Print2DArray(productArray);

////////////////////////

static int[,] GetProductArray(int[,] array1, int[,] array2)
    {
        int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];        
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int a = 0; a < array2.GetLength(0); a++)
                {
                    result[i,j] = result[i,j] + array1[i,a] * array2[a,j];
                }            
            }
        }
        return result;
    }

///////////////////////

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