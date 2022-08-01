/*
Задача № 46
Показать числа Фибоначчи
*/
System.Console.WriteLine("Сколько чисел будем выводить?");
int N = int.Parse(Console.ReadLine());
int fib1 = 1;
int fib2 = 1;
int fibSum = 0;
int [] arr = new int[N];
int i = 0;
while (N-2 < 0)
{
    fibSum = fib1 + fib2;
    fib1 = fib2;
    fib2 = fibSum;
    i = i + 1;
    System.Console.WriteLine(fib2);
}

