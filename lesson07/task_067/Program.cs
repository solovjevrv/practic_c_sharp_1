/*
Задача № 67
Показать натуральные числа от N до 1, N задано
*/

void Loop(int N, int i)
{
  System.Console.Write($"{N} ");
  if (i < N)
  {
    Loop(N - 1, i);
  }

}

Loop(10, 1);