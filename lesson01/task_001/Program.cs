/* 
Задача № 1
С клавиатуры вводится целое число. Вывести квадрат числа 
*/

double a;
double b;
System.Console.WriteLine("Введите число:");
string? s = Console.ReadLine();
a = Convert.ToDouble(s);

b = a * a;

System.Console.WriteLine($"Квадрат числа {a} равен: {b}");