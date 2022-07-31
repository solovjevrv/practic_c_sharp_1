/*
Задача № 44
Написать программу преобразования десятичного числа в двоичное
*/
System.Console.WriteLine("Enter number...");
int num = int.Parse(Console.ReadLine());
// int[] a = new int[10];
while (num > 0) 
{
    num = num % 2;
    System.Console.WriteLine(num);
    
}


