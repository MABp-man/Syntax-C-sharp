Console.Clear();

int[,] newArray = NewRandom2DArray(4, 4, 0, 10);
Print2DArray(newArray);
int[,] newArray2 = ChangeRows2DArray(newArray, 0, newArray.GetLength(0)-1);
Console.WriteLine();
Print2DArray(newArray2);
int[,] newArray3 = RowsToColumns2DArray(newArray);
Console.WriteLine();
Print2DArray(newArray3);
ItemQuantaty2DArray (newArray, 0, 10);

///////////////////////

static void ItemQuantaty2DArray (int[,] array, int fromItem, int toItem)
{
    Console.WriteLine();
    for (int temp = fromItem; temp < toItem + 1; temp++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] == temp) count++;               
            }
        }
        Console.WriteLine($"{temp} встречается в массиве {count} раз");
    }
}

////////////////////////

static int[,] RowsToColumns2DArray(int[,] array)
{
    int [,] transpArray = new int[array.GetLength(1),array.GetLength(0)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            transpArray[j, i] = array[i, j];
        }
    }
    return transpArray;
}

//////////////////////////

static int[,] ChangeRows2DArray(int[,] array, int firstRow, int secondRow)
{
    int temp = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[firstRow, j];
        array[firstRow, j] = array[secondRow, j];
        array[secondRow, j] = temp;
    }
    return array;
}

/////////////////////////
static int[,] NewRandom2DArray(int rows, int columns, int from, int to)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array [i, j] = new Random().Next(from, to + 1);
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
