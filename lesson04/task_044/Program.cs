/*
Задача № 44
Написать программу преобразования десятичного числа в двоичное
*/
System.Console.WriteLine("Enter number...");
int num = int.Parse(Console.ReadLine());

System.Console.WriteLine(DecToBin(num));;
string DecToBin(int num)
{
    if (num == 0) return "0";
    string s = "";
    while (num != 0)
    {
        s = (num % 2) + s;
        num /= 2;
    }
    return s;
}
