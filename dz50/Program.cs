// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
int[,] newArray = NewRandom2DArray(3, 4, -100, 101);

Console.Write("Чтобы получить элемент массива, введите ");
int rowNumber = GetNumberFromUser("номер строки: ");
int columnNumber = GetNumberFromUser("и номер столбца: ");

PrintItemFrom2DArray(newArray, rowNumber, columnNumber);

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

/////////////////////

static int GetNumberFromUser(string Welcome)
{
    int N;
    while (true)
        {
            Console.WriteLine(Welcome);
            if(int.TryParse(Console.ReadLine(), out N)) 
                if(N >= 0)
                    break;
            Console.Clear();
            Console.WriteLine("Ошибка ввода!");
        }
    return N;
}

///////////////////////

static void PrintItemFrom2DArray(int[,] array2, int rowNumber, int columnNumber)
{
    if (rowNumber < array2.GetLength(0) && columnNumber < array2.GetLength(1))
    {
        Console.Write($"В ячейке ({rowNumber}, {columnNumber}) число: ");
        Console.WriteLine(array2[rowNumber, columnNumber]);
    }
    else
    {
        Console.WriteLine("В этом массиве нет ячейки с таким адресом.");
    }
}