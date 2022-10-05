int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = num % 10;
Console.WriteLine($"{num} => {a1}{a2}");

Console.Write("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());
if(n1 % n2 == 0) Console.WriteLine($"{n1}, {n2} => Кратно");
else Console.WriteLine($"{n1}, {n2} => не кратно. Остаток {n1 % n2}");