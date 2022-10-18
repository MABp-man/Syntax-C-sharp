
int[] array = new int[12];
int sumN = 0;
int sumP = 0;
for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(-9,10);
    if (array[i] < 0) 
    {
        sumN += array[i];
    }
    else
    {
        sumP += array[i];
    }
}
Console.Write($"{WriteArrayToConsole(array)} => ");
Console.WriteLine($"Отрицательная сумма {sumN}, положительная сумма {sumP}");
ReversArray(array);
Console.Write($"Реверсивный массив: ");
Console.WriteLine(WriteArrayToConsole(array));
Console.WriteLine($"{FindNumberInArray(array, 4)}");

/////////////////////

static bool FindNumberInArray(int[] array, int number)
{
    foreach (int item in array)
    {
        if (item == number) return true;
        else return false;
    }
    
}

/////////////////

static void ReversArray(int[] array)
{
        for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}

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