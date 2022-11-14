Console.Clear();
int start = NumberInput("Введите первое число: ");
int end = NumberInput("Введите второе число: ");
Console.WriteLine(PrintNumbersAtoB(start, end));
int num = NumberInput("Введите целое число: ");
Console.WriteLine($"{num} => {GetDigitSum(num)}");
Console.WriteLine(PowAtoBRec(start, end));


/////////////////////

static string PrintNumbersAtoB(int end, int start)
    {
        if (start <= end)
        {
            if (start < end) return "Ошибка: первое число больше второго.";
            else return $"{end}";
        }
        else return PrintNumbersAtoB(end, start - 1) + $" {start}";
    }

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

static int GetDigitSum(int number)
    {
        if (number/10 == 0) return number;
        else return GetDigitSum(number/10) + number%10;
    }

////////////////

static int PowAtoBRec(int number, int power)
    {
        
        if (power == 0) return 1;
        else
        {
            if (power < 0) return PowAtoBRec(number, power + 1) * number;
            else return PowAtoBRec(number, power - 1) * number;
        }
    }

////////////////