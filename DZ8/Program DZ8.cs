Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
double N = double.Parse(userInput);
int count = 0;

while (count <= N)
{
    Console.Write(count + ", ");
    count = count + 2;
}