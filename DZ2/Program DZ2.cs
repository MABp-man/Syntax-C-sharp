Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
double Number1 = double.Parse(userInput1);
double Number2 = double.Parse(userInput2);

if (Number1 == Number2)
{
    Console.WriteLine("Числа равны");
}
else if (Number1 > Number2)
{
    Console.WriteLine(Number1 + " больше " + Number2);
}
    else
    {
        Console.WriteLine(Number1 + " меньше " + Number2);
    }