/*
Задача № 49
Показать двумерный массив размером m×n заполненный вещественными случайными числами
*/

int N = 3;
int M = 2;
double[,] a = new double[N, M]; //описываем и создаем массив
// ИНициализация случаными числами
Random random = new Random(); // Объект типа Random

// заполнение массива
for (int i = 0; i < a.GetLength(0); i++)
{
  for (int j = 0; j < a.GetLength(1); j++)
  {
    a[i, j] = random.NextDouble() * 10 + 1;
  }
}
// вывод массива
for (int i = 0; i < a.GetLength(0); i++)
{
  for (int j = 0; j < a.GetLength(1); j++)
  {
    System.Console.Write($"{a[i, j]:F2} ");
  }
  System.Console.WriteLine();
}
