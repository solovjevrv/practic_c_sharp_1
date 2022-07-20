/**
Задача № 26
Найти сумму чисел от 1 до А
*/

System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;

int getSum (int num)
{
    for (int i = 1; i<=num; i++)
    {
        sum += i;
    }
    return sum;

}
System.Console.WriteLine($"Сумма чисел от 1 до {num} равна: {getSum(num)}");