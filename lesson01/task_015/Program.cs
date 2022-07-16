/*
Задача № 15
С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.
*/
System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num > 99)
{
  System.Console.WriteLine(num / 100 % 10);
}
else
{
  System.Console.WriteLine($"Число {num} двузначное! Введите число, в котором более двух цифр.");
}