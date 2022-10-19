// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = NewRandomArray(-100, 101, 6);
WriteArrayToConsole(array);
Console.WriteLine($"Сумма чисел на нечётных позициях: {EvenNumberItemsSum(array)}");

///////////////////////////

static int EvenNumberItemsSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum +array[i];
    }
    return sum;
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