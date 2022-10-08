Console.Clear();
int quarter;

while (true)
{
    Console.WriteLine("Введите номер четверти системы координат: ");
    if(int.TryParse(Console.ReadLine(), out quarter)) 
        if (quarter < 5 && quarter > 0) break;
    Console.Clear();
    Console.WriteLine("Ошибка ввода!");
}

QuarterRange(quarter);


static void QuarterRange(int quarter)
{
if (quarter == 1)
    Console.WriteLine("X > 0, Y > 0");
else if (quarter == 2)
        Console.WriteLine("X < 0, Y > 0");
    else if (quarter == 3)
            Console.WriteLine("X < 0, Y < 0");
        else if (quarter == 4)
             Console.WriteLine("X > 0, Y > 0");
}