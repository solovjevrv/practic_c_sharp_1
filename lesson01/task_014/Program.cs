/*
Задаяча № 14
С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
*/

Console.WriteLine("Введите первое число a:");
var a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число b:");
var b = int.Parse(Console.ReadLine());
var dev = a % b;
if (dev == 0)
{
  Console.WriteLine($"Число {a} кратно числу {b}");
}
else
{
  Console.WriteLine($"Число {a} не кратно числу {b}, остаток от деления {dev}");
}