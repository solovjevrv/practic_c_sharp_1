/*
Задача № 16
Дано число. Проверить кратно ли оно 7 и 23
*/

System.Console.WriteLine("Введите число: ");
string? temp = Console.ReadLine();
int num = Convert.ToInt32(temp);

if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine("Число кратно 7 и 23");
}
else
{
    System.Console.WriteLine("Число НЕ кратно 7 и 23");
}