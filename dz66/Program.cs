// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();
int start = NumberInput("Введите первое число: ");
int end = NumberInput("Введите второе число: ");
Console.WriteLine(GetSumFromAtoB(start, end));

/////////////////////

static int NumberInput(string welcome)
    {
        int n;
        while (true)
        {
            Console.WriteLine(welcome);
            if(int.TryParse(Console.ReadLine(), out n)) break;
            Console.Clear();
            Console.WriteLine("Ошибка ввода!");
        }
        return n;
    }

/////////////////

static int GetSumFromAtoB(int start, int end)
    {
        if (start == end) return end;
        else 
        {
            if (start < end) return GetSumFromAtoB(start + 1, end) + start;
            else return GetSumFromAtoB(start - 1, end) + start;
        }
    }

////////////////