// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Для вычисления функции Аккермана введите целые положительные числа:");
int m = NumberInput("m = ");
int n = NumberInput("n = ");
Console.WriteLine($"A({m},{n}) = {AkkermanResult(m, n)}");

/////////////////////

static int NumberInput(string welcome)
    {
        int n;
        while (true)
        {
            Console.Write(welcome);
            if(int.TryParse(Console.ReadLine(), out n) && n != 0) break;
            Console.WriteLine("Ошибка ввода!");
        }
        return n;
    }

/////////////////

static int AkkermanResult(int m, int n)
    {
        if (m == 0) return n + 1;
        else 
        {
            if (n == 0) return AkkermanResult(m - 1, 1);
            else return AkkermanResult(m - 1, AkkermanResult(m, n - 1));
        }
    }

////////////////