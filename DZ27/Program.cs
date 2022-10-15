// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int num = GetNaturalNumberFromUser("Введите целое число: ");
Console.WriteLine($"{num} => {GetDigitSum(num)}");

////////////////////

static int GetDigitSum(int number)
{
    if (number < 0) 
        number = number * -1;

    int sum = number % 10;
    while (number > 0)
    {
        number = number / 10;
        sum = sum + number % 10;
    }
    return sum;
}

////////////////
static int GetNaturalNumberFromUser(string Welcome)
{
int Number;
while (true)
{
    Console.Write(Welcome);
    if(int.TryParse(Console.ReadLine(), out Number)) break;
    Console.WriteLine("Ошибка ввода!");
}
return Number;
}