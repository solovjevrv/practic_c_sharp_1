/*
Задаяча № 12
С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
*/

System.Console.WriteLine("Введите число от 10 до 99: ");
string? temp = Console.ReadLine();
int num = Convert.ToDouble(temp);

// int first_digit = num / 10;
// int last_digit = num % 10;

System.Console.WriteLine(num / 10, num % 10);