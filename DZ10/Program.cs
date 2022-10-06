int varA;
while (true)
{
    Console.Write("Введите трехзначное число: ");
    if(int.TryParse(Console.ReadLine(), out varA)) 
        if(varA > 99 && varA < 1000) break;
    Console.WriteLine("Ошибка ввода!");
} 
Console.WriteLine($"{varA} => {varA % 100 / 10}");