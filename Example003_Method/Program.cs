double varA;
while (true)
{
    Console.WriteLine("Введите число: ");
    if(double.TryParse(Console.ReadLine(), out varA)) break;
    Console.WriteLine("Ошибка ввода!");
}

Console.WriteLine($"A={varA}");
