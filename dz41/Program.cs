// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
int[] NewArray = GetArrayFromUser("Сколько чисел будете вводить? ", "Введите целое число");
Console.WriteLine($"{string.Join(", ", NewArray)} => {positivesInArray(NewArray)} положительных");

/////////////////////

static int positivesInArray(int[] array)
{
    int posCount = 0;
    foreach (int item in array)
    {
        if (item > 0) posCount++;
    }
    return posCount;
}

/////////////////////

static int GetNumberFromUser(string Welcome)
{
    int N;
    while (true)
        {
            Console.WriteLine(Welcome);
            if(int.TryParse(Console.ReadLine(), out N)) break;
            Console.Clear();
            Console.WriteLine("Ошибка ввода!");
        }
    return N;
}

/////////////////////////

static int[] GetArrayFromUser(string WelcomeMessage1, string WelcomeMessage2)
{
    int size = GetNumberFromUser(WelcomeMessage1);
    int Number;
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        while (true)
        {
            Console.Write($"{WelcomeMessage2} №{i+1}: ");
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
