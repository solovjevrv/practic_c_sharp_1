/*
Задача № 6
Написать программу вычисления значения функции y = sin(a). (Класс Math). 
*/
System.Console.WriteLine("Введите число:");
string? temp = Console.ReadLine();
double a = Convert.ToDouble(temp);
double y = Math.Sin(a);
System.Console.WriteLine(($"Синус введенного числа равен: {y}"));