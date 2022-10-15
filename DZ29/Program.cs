// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] NewArray = GetArrayFromUser("Введите размер массива: ", "Введите целое число в ячейку");
Console.Clear();
Console.Write ("Ваш массив создан: ");
Console.Write (WriteArrayToConsole(NewArray));

////////////////////

static int[] GetArrayFromUser(string WelcomeMessage1, string WelcomeMessage2)
{
    Console.Clear();
    int size, Number;
    while (true)
    {
            Console.Write(WelcomeMessage1);
            if(int.TryParse(Console.ReadLine(), out size)) break;
            Console.WriteLine("Ошибка ввода!");
    }
    
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        while (true)
        {
            Console.Write($"{WelcomeMessage2} номер {i+1}: ");
            if(int.TryParse(Console.ReadLine(), out Number)) 
            {
                array[i] = Number;
                break;
            }
            Console.WriteLine("Ошибка ввода!");
        }
        
    
    }
    return array;
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