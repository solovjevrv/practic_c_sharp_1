/*
Задача № 66
Показать натуральные числа от 1 до N, N задано
*/

void Loop(int i, int N)
{
  System.Console.Write($"{i} ");
  if (i < N)
  {
    Loop(i + 1, N);
  }
  else return;
}

Loop(1, 10);