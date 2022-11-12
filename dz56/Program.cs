// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
// int[,] newArray = {{1, 4, 7 ,2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};  // строка для проверки
int[,] newArray = NewRandom2DArray(4, 5, -100, 101);
Print2DArray(newArray);
Console.WriteLine();
FindMinRowSum(newArray);

////////////////////////

static void FindMinRowSum(int[,] array)
    {
        int min = RowSum(array, 0);
        int indexMin = 0;
        for (int i = 1; i < array.GetLength(0); i++)
        {        
            if (RowSum(array, i) < min)
               {
                    min = RowSum(array, i);
                    indexMin = i;
               }
        }
        Console.Write("Строка с минимальной суммой элементов: ");
        Console.WriteLine($"{indexMin + 1} ({RowSum(array, indexMin)})");
    }

///////////////////////

static int RowSum(int[,] array, int row)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
            sum = sum + array[row, i];            
        return sum;
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