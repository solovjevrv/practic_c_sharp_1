/*
Задача № 6
Написать программу вычисления значения функции y = sin(a). (Класс Math). 
*/
System.Console.WriteLine("Введите число:");
string? temp = Console.ReadLine();
double a = Convert.ToDouble(temp);
double y = Math.Sin(a);
System.Console.WriteLine(($"Синус введенного числа равен: {y}"));


// решение через функцию
// System.Console.WriteLine("Введите число:");
// string? temp = Console.ReadLine();
// double a = Convert.ToDouble(temp);
// double Sin(double a)
// {
//     return Math.Sin(a);
// }
// double y=Sin(a);
// System.Console.WriteLine(y);


