static int CoordinateInput(string coordinates)
{
    Console.Write(coordinates);
    int coords = int.Parse(Console.ReadLine() ?? "");
    return coords;
}

static double DistanceCount(int X1, int Y1, int X2, int Y2)
{
    double distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
    return distance;
}

int X1, Y1, X2, Y2;

X1 = CoordinateInput("Введите координату X первой точки: ");
Y1 = CoordinateInput("Введите координату Y первой точки: ");
X2 = CoordinateInput("Введите координату X второй точки: ");
Y2 = CoordinateInput("Введите координату Y второй точки: ");

double distance = DistanceCount(X1, Y1, X2, Y2);
Console.WriteLine(distance);