/*
Задача № 69
Найти сумму элементов от M до N, N и M заданы 
*/

int Loop(int M, int N)
{
  if (M == N) return M;
  else return Loop(M + 1, N) + M;
}

System.Console.WriteLine(Loop(1, 10));