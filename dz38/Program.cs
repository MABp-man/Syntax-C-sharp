// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] array = NewRandomArray(-100, 101, 6);
WriteArrayToConsole(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {FindMaxInArray(array) - FindMinInArray(array)}");

////////////////////////

static double[] NewRandomArray(int from, int to, int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(from, to) + new Random().NextDouble();
    }
    return array;
}

////////////////////

static void WriteArrayToConsole(double[] NumbersArray)
{
    Console.Write("[");
    for (int i = 0; i < NumbersArray.Length - 1; i++)
    {
        Console.Write($"{NumbersArray[i]}, ");
    }
    Console.WriteLine($"{NumbersArray[NumbersArray.Length - 1]}]");

    return;
}

///////////////////////

static double FindMaxInArray(double[] array)
{
    double maxItem = array[0];
    foreach (double item in array)
    {
        if (item > maxItem) maxItem = item;
    }
    return maxItem;
}

///////////////////////

static double FindMinInArray(double[] array)
{
    double minItem = array[0];
    foreach (double item in array)
    {
        if (item < minItem) minItem = item;
    }
    return minItem;
}