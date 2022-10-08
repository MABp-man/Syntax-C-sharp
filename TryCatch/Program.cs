Console.Clear();
int X, Y;

try
{
    Console.Write("Введите координату X: ");
    X = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите координату Y: ");
    Y = int.Parse(Console.ReadLine() ?? "");
}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных: {exc.Message}");
    return;
}