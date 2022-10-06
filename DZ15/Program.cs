int varA;
while (true)
{
    Console.Write("Введите номер дня недели: ");
    if(int.TryParse(Console.ReadLine(), out varA)) 
        if(varA < 8 && varA > 0) break;
    Console.WriteLine("Ошибка ввода!");
} 
Console.Write(varA);
if (varA > 5)
    Console.WriteLine(" => да");
else
    Console.WriteLine(" => нет");
