Console.Write("Введите число: ");
string userInput1 = Console.ReadLine() ?? "";
double Number1 = double.Parse(userInput1);

if (Number1 % 2 == 0)
{
    Console.Write("Число чётное");
}
else
{
    Console.Write("Число нечётное");
}