/*
Задача № 17
Дано число обозначающее день недели. Выяснить является номер дня недели выходным
*/
System.Console.WriteLine("Введите число от 1 до 7: ");
string? temp = Console.ReadLine();
int num = Convert.ToInt32(temp);

// номера для выходных 6 и 7
if (num == 6 || num == 7)
{
    System.Console.WriteLine("Это выходной день!");
}
else if (num > 7)
{
    System.Console.WriteLine("Вы ввели неверное число");
}
else
{
    System.Console.WriteLine("Это будний день!");
}