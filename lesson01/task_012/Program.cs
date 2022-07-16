/*
Задаяча № 12
С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
*/

System.Console.WriteLine("Введите число от 10 до 99: ");

int num = Convert.ToInt32(Console.ReadLine());

int first_digit = num / 10;
int last_digit = num % 10;

System.Console.WriteLine(first_digit);
System.Console.WriteLine(last_digit);