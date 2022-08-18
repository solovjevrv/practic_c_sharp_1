/*
Нахождение факториала числа n с использованием рекурсии
*/

int Factorial(int n)
{
  if (n > 0) return Factorial(n - 1) * n;
  else return 1;
}
System.Console.WriteLine(Factorial(5));