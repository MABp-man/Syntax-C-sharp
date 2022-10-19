// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Clear();
int[] array = NewRandomArray(100, 1000, 9);
WriteArrayToConsole(array);
Console.WriteLine($"Чётных чисел в массиве: {OddsInArray(array)}");

//////////////////////////

static int OddsInArray(int[] array1)
{
    int oddsCount = 0;
    foreach (int item in array1)
    {
        if (item % 2 == 0) oddsCount++;         
    }    
    return oddsCount;
}

////////////////////////

static int[] NewRandomArray(int from, int to, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(from, to);
    }
    return array;
}

////////////////////

static void WriteArrayToConsole(int[] NumbersArray)
{
    Console.Write("[");
    for (int i = 0; i < NumbersArray.Length - 1; i++)
    {
        Console.Write($"{NumbersArray[i]}, ");
    }
    Console.WriteLine($"{NumbersArray[NumbersArray.Length - 1]}]");

    return;
}