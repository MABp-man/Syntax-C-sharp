// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] NewArray = {1, 2, 5, 7, 19};

Console.Write (WriteArrayToConsole(NewArray));


////////////////////
static string WriteArrayToConsole(int[] NumbersArray)
{
    Console.Write("[");
    for (int i = 0; i < NumbersArray.Length - 1; i++)
    {
        Console.Write($"{NumbersArray[i]}, ");
    }
    string writeArray = $"{NumbersArray[NumbersArray.Length - 1]}]";
    return writeArray;
}