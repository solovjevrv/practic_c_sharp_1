/* 
Задача № 3
С клавиатуры вводятся два числа a и b. Найти максимальное из них
*/
System.Console.WriteLine("Введите первое число:");
string? temp = Console.ReadLine();
System.Console.WriteLine("Введите второе число:");
int a = Convert.ToInt32(temp);
temp = Console.ReadLine();
int b = Convert.ToInt32(temp);
int max = a;

if (max > b)
{
    max = a;
    System.Console.WriteLine($"Масимальное первое число - {max}");
}
else
{
    max = b;
    System.Console.WriteLine($"Масимальное второе число - {max}");
}



