/*
Задача № 70
Найти сумму цифр числа
*/

int SumDigit(int N)
{
  if (N < 10) return N;
  else return N % 10 + SumDigit(N / 10);

}
System.Console.WriteLine(SumDigit(11));