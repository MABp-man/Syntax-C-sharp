// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int A = GetNaturalNumberFromUser("Введите число: ");
int B = GetNaturalNumberFromUser("Введите показатель степени: ");
Console.WriteLine($"{A}, {B} => {GetExponent(A, B)}");



////////////////
static int GetNaturalNumberFromUser(string Welcome)
{
int Number;
while (true)
{
    Console.Write(Welcome);
    if(int.TryParse(Console.ReadLine(), out Number)) 
        if (Number > 0) break;
    Console.WriteLine("Ошибка ввода!");
}
return Number;
}
    
/////////////////////

static int GetExponent(int number, int exponent)
{
    int result = number;
    for (int i = 1; i < exponent; i++)
    {
        result = result * number;
    }
    return result;
}