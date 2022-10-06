int varA;
while (true)
{
    Console.Write("Введите целое число: ");
    if(int.TryParse(Console.ReadLine(), out varA)) break;
    Console.WriteLine("Ошибка ввода!");
} 
Console.Write($"{varA} => ");

if(varA < 100) 
    Console.WriteLine("третьей цифры нет");
else
{
    while (varA > 999)
    {
        varA = varA / 10;
    }
    Console.WriteLine(varA % 10);
}