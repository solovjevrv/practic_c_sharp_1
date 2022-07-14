/*
Задача № 5
С клавиатуры вводятся три числа. Найти максимальное из трех чисел
*/

System.Console.WriteLine("Введите первое число:");
string? temp = Console.ReadLine();
System.Console.WriteLine("Введите второе число:");
int num1 = Convert.ToInt32(temp);
temp = Console.ReadLine();
int num2 = Convert.ToInt32(temp);
System.Console.WriteLine("Введите третье число:");
temp = Console.ReadLine();
int num3 = Convert.ToInt32(temp);

int max = num1;

if (num1 > num2 && num1 > num3)
{
    max = num1;
    System.Console.WriteLine($"Масимальное первое число - {max}");
}
else if (num2 > num3 && num2 > num1)
{
    max = num2;
    System.Console.WriteLine($"Масимальное второе число - {max}");
}
else
{
    max = num3;
    System.Console.WriteLine($"Масимальное третье число - {max}");
}