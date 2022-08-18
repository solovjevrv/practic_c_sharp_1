/*
Задача № 71
Написать программу вычисления функции Аккермана
*/

int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
    return Akkerman(n - 1, 1);
  else
    return Akkerman(n - 1, Akkerman(n, m - 1));
}

System.Console.WriteLine(Akkerman(2, 2));