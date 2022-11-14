// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int num = NumberInput("Введите целое число: ");
Console.WriteLine(PrintNumbersNto1(num));

/////////////////////

static string PrintNumbersNto1(int number)
    {
        if (number == 1) return $"{1}";
        else
        {
            if (number < 1) return $"{number} " + PrintNumbersNto1(number + 1);
            else return $"{number} " + PrintNumbersNto1(number - 1);
        }
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

////////////////////////////