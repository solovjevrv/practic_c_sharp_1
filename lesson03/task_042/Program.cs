/*
Задача № 42
Выяснить являются ли три числа сторонами треугольника
*/
if (isTriangle(a, b, c) == true)
{
    System.Console.WriteLine("Числа являются сторонами треугольника!");
}
else System.Console.WriteLine("Числа не являются сторонами треугольника!");


bool isTriangle (double a, double b, double c)
{
    return (a + b > c && b + c > a && a + c > b);
}

System.Console.WriteLine("Введите первое число...");
double a = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите второе число...");
double b = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите третье число...");
double c = double.Parse(Console.ReadLine());

