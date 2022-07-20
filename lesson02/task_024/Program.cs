/**
Задача № 24
Вывести на экран таблицу квадратов чисел от 1 до N
*/

System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i<=num; i++)
{
    System.Console.WriteLine($"{i}^2 = {i*i}");
}


