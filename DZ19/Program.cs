Console.Clear();
int fiveDigitN = FiveDigitInput("Введите пятизначное число: ");
PalindromCheck(ref fiveDigitN);

/////////////////////

static int FiveDigitInput(string Welcome)
{
int fiveDigitN;
while (true)
{
    Console.WriteLine(Welcome);
    if(int.TryParse(Console.ReadLine(), out fiveDigitN)) 
        if (fiveDigitN < 100000 && fiveDigitN > 9999) break;
    Console.Clear();
    Console.WriteLine("Ошибка ввода!");
}
return fiveDigitN;
}
/////////////////

static void PalindromCheck(ref int fiveDigitN)
{
    if (fiveDigitN / 10000 == fiveDigitN % 10 && (fiveDigitN / 1000) % 10 == (fiveDigitN % 100) / 10)
        Console.WriteLine(fiveDigitN + " => палиндром");
    else
        Console.WriteLine(fiveDigitN + " => НЕ палиндром");
}