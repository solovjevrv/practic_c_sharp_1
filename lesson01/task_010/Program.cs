/*
Задача № 10
Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
*/
System.Console.WriteLine("Введите число:");
string? temp = Console.ReadLine();
int num = Convert.ToInt32(temp);

int last_digit = num % 10;

System.Console.WriteLine($"Последняя цифра введенного числа: {last_digit}");