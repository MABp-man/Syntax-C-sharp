// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int[,,] newArray = NewRandom3DArray(2, 3, 3, 10, 100);
Print3DArray(newArray);

///////////////////////

static int[,,] NewRandom3DArray(int rows, int columns, int shelfs, int from, int to)
    {
       int[,,] array = new int[rows, columns, shelfs];
       int temp = new Random().Next(from, to);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int k = 0; k < shelfs; k++)
                {
                    while (CheckItemIn3DArray(array, temp))
                    {
                        temp = new Random().Next(from, to);
                    }
                    array[i,j,k] = temp;
                } 
            }
        }
        return array;
    }

///////////////////////

static bool CheckItemIn3DArray(int[,,] array, int item)
{
    for (int i1 = 0; i1 < array.GetLength(0); i1++)
    {
        for (int j1 = 0; j1 < array.GetLength(1); j1++)
        {
            for (int k1 = 0; k1 < array.GetLength(2); k1++)
            {
                if (array [i1, j1, k1] == item) return true;
            }
        }
    }
    return false;
}

///////////////////////

static void Print3DArray(int[,,] array)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.WriteLine("  ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j, k]} ({i}, {j}, {k})  ");
                }
            }
        }
    }