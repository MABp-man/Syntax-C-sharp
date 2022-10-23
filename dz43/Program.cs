//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
 
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
int[,] lines = GetStraightLinesFromUser("Сколько прямых будем добавлять? ");

double x = intersectionCoords(lines, 1, 2)[0];
double y = intersectionCoords(lines, 1, 2)[1];
Console.Write($"k1 = {lines[0,0]}, b1 = {lines[0,1]}, k2 = {lines[1,0]}, b2 = {lines[0,1]}");
Console.WriteLine($" => ({x}; {y})");

////////////////////////

static double[] intersectionCoords(int[,] straights, int firstLine, int secondLine)
{
    double x = (double)(straights[secondLine - 1, 1] - straights[firstLine - 1, 1])/(straights[firstLine - 1, 0] - straights[secondLine - 1, 0]);
    double y = x* straights[firstLine - 1, 0] + straights[firstLine - 1, 1];
    double[] coords = {x, y};
    return coords;
}

////////////////////////
static int[,] GetStraightLinesFromUser(string message)
{
    int linesNumber = GetNumberFromUser(message);
    int[,] straightsArray = new int[linesNumber, 2];
    for (int i = 0; i < linesNumber; i++)
    {
        Console.WriteLine($"Для прямой y = k{i + 1} * x + b{i + 1}");
        straightsArray[i, 0] = GetNumberFromUser($"Введите коэффициент k{i + 1}: ");
        straightsArray[i, 1] = GetNumberFromUser($"Введите коэффициент b{i + 1}: ");
    }
    return straightsArray;
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