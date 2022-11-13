//  Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Console.Clear();
int[,] newArray = newSpiral2DArray(5, 10);
Print2DArray(newArray);

////////////////////////

static int[,] newSpiral2DArray(int rows, int columns)
   {
       int[,] array = new int[rows, columns];
       int limit = 0;
       int itemCount = 10;
       int i = 0;
       int j = 0;
       int max = rows * columns + itemCount;
        for (; itemCount < max; rows--, columns--, limit++)
        {
            i = limit;
            for (j = limit; j < columns; j++)
            {
                if (itemCount < max)
                    array [i, j] = itemCount++;
            }
            j = columns - 1;
            for (i = limit + 1; i < rows; i++)
            {
                if (itemCount < max)
                    array [i, j] = itemCount++;
            }
            i = rows - 1;
            for (j = columns - 2; j >= limit; j--)
            {
                if (itemCount < max)
                    array [i, j] = itemCount++;
            }
            j = limit;
            for (i = rows - 2; i > limit; i--)
            {
                if (itemCount < max)
                    array [i, j] = itemCount++;
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