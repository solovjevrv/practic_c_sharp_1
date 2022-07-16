/*
Задача № 28
Определить количество цифр в числе. Сделать подпрограмму.
*/
System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int CountDigits(int N)
{
    if (N == 0) return 1;
    int Count = 0;
    while (N != 0)
    {
        Count++;
        N = N / 10;
    }
    return Count;
}
System.Console.WriteLine(CountDigits(N));