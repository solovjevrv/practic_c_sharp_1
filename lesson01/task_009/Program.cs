/*
Задача № 9
Вывести на экран четные числа от 1 до N
*/
int start = 1;
int end = 30;
while (start <= end)
{
    if (start % 2 == 0)
    {
        System.Console.Write($"{start} ");
    }

    start++;
}