/*
Задача № 18
По двум заданным числам проверять является ли одно квадратом другого. Используйте подпрограмму.
*/
bool IsSquare(int x, int y)
{
    return x * x == y;
}

System.Console.WriteLine("Введите первое число: ");
string? temp = Console.ReadLine();
int x = Convert.ToInt32(temp);
System.Console.WriteLine("Введите второе число: ");
temp = Console.ReadLine();
int y = Convert.ToInt32(temp);

if (IsSquare(x, y))
{
    System.Console.WriteLine($"Число {x} является квадратом {y} ");
}
else
{
    if (IsSquare(y, x))
    {
        System.Console.WriteLine($"Число {y} является квадратом {x} ");
    }
    else
    {
        System.Console.WriteLine("Ни одно число не является квадратом другого");
    }
}