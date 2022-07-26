/*
Задача № 30
Написать программу вычисления произведения чисел от 1 до N
*/


int multi = 1;

System.Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
	multi *= i;
}
System.Console.WriteLine($"Произведение чисел от 1 до {N} равно {multi}!");