/**
Задача № 25
Вывести на экран кубы чисел от 1 до N
*/

System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i<=num; i++)
{
    System.Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
}
