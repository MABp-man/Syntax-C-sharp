Console.Clear();
int a = GetNumberFromUser("Введите первое число :");
int b = GetNumberFromUser("Введите второе число :");
int c = GetNumberFromUser("Введите третье число :");
Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} " + CheckTriangle(a, b, c));

int Number = GetNumberFromUser("Введите целое число :");
Console.WriteLine($"{Number} => {transformIntToBit(Number)}");

/////////////////////

static int transformIntToBit(int Number)
{
    int bitResult = 0;
    int count = 1;
    while ((Number * 10)/ 2 != 0)
    {
        bitResult = bitResult + Number % 2 * count;
        Number = Number / 2;
        count = count * 10;
    }
    return bitResult;
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
/////////////////

static string CheckTriangle(int firstSide, int secondSide, int thirdSide)
{
    string resultMessage  = "не существует";
    if (firstSide < secondSide + thirdSide && thirdSide < secondSide + firstSide && secondSide < firstSide + thirdSide)  
    {
        resultMessage = "существует";
    }
    return resultMessage;
}

///////////

// double.Epsilon - наименьшее возможное число дабл в системе
// сравнивать через == дабл нельзя
// правильно сравнить модуль разницы с наименьшим числом дабл