Console.Write("Введите первое целое число: ");
string userInput1 = Console.ReadLine() ?? "";
Console.Write("Введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";
int Number1 = int.Parse(userInput1);
int Number2 = int.Parse(userInput2);
if (Number1 == Number2 * Number2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("нет");
}

Console.Write("Введите число от 1 до 7: ");
string day = Console.ReadLine() ?? "";
int dayNumber = int.Parse(day);
if (dayNumber == 1)
{
    Console.WriteLine("понедельник");
}
else
{
    if (dayNumber == 2)
{
    Console.WriteLine("вторник");
}
    else
{
        if (dayNumber == 3)
{
        Console.WriteLine("среда");
}
        else
{
            if (dayNumber == 4)
{
            Console.WriteLine("четверг");
}
            else
{
                if (dayNumber == 5)
{
                Console.WriteLine("пятница");
}
                else
{
                    if (dayNumber == 6)
{
                    Console.WriteLine("суббота");
}
                    else
{
                        if (dayNumber == 7)
{
                        Console.WriteLine("воскресенье");
}
                        else
{
                        Console.WriteLine("неверное число");
}
}
}
}
}
}
}

