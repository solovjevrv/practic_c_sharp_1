// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Loop(int M, int N)
{
  if (M == N) return M;
  else return Loop(M + 1, N) + M;
}

System.Console.WriteLine(Loop(1, 15));