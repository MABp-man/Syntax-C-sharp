Console.clear();
int = x, y;

try
{
    Console.Write("Введите координату X: ");
    x = int.Parse(Console.Readline() ?? "");

    Console.Write("Введите координату Y: ");
    y = int.Parse(Console.Readline() ?? "");
}
catch (Exception exc)
{
    Console.Writeline($"Ошибка ввода данных: {exc.Message}");
    return;
}