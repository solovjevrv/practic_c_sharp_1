/* 
Задача № 2
С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго
*/
System.Console.WriteLine("Введите первое число:");
string? temp = Console.ReadLine();
System.Console.WriteLine("Введите второе число:");

int number1 = Convert.ToInt32(temp);
temp = Console.ReadLine();
int number2 = Convert.ToInt32(temp);

if (number2 == number1 * number1)
{
    System.Console.WriteLine($"Число {number2} является квадратом числа {number1}");
}
else
{
    if (number1 == number2 * number2)
    {
        System.Console.WriteLine($"Число {number1} является квадратом числа {number2}");
    }
    else
    {
			System.Console.WriteLine("Ни одно число не является квадратом другого");
    }
}
