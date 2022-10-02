Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
Console.Write("Введите третье число: ");
string userInput3 = Console.ReadLine() ?? "";
double maxNum = double.Parse(userInput1);
double Number2 = double.Parse(userInput2);
double Number3 = double.Parse(userInput3);

if (maxNum < Number2)
{
    maxNum = Number2;
}
else if (maxNum < Number3)
{
        maxNum = Number3;
}
Console.Write("Наибольшее значение " + maxNum);