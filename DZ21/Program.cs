static int CoordinateInput(string coordinate)
{
    Console.Write(coordinate);
    int coord = int.Parse(Console.ReadLine() ?? "");
    return coord;
}
///////////////////////////
static double DistanceCount(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
    return distance;
}
/////////////////////////////////
/////////////////////////////////////
int X1, Y1, Z1, X2, Y2, Z2;

X1 = CoordinateInput("Введите координату X точки А: ");
Y1 = CoordinateInput("Введите координату Y точки А: ");
Z1 = CoordinateInput("Введите координату Z точки А: ");
X2 = CoordinateInput("Введите координату X точки В: ");
Y2 = CoordinateInput("Введите координату Y точки В: ");
Z2 = CoordinateInput("Введите координату Z точки В: ");

double distance = DistanceCount(X1, Y1, Z1, X2, Y2, Z2);
Console.WriteLine(distance);