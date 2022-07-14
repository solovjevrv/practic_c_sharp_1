/* 
Задача № 7
Выяснить является ли число чётным.
*/

System.Console.WriteLine("Введите число:");
string? temp = Console.ReadLine();
int a = Convert.ToInt32(temp);

if (a % 2 == 0)
{
    Console.WriteLine("Вы ввели четное число!");
}
else
{
    Console.WriteLine("Введенное число не является четным!");
}