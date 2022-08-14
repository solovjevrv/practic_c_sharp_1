/*
Задача № 48
Создать массив NxM и заполнить его случайными числами от 1 до 10. Вывести на экран
*/

int N = 3;
int M = 2;
int[,] a = new int[N, M]; //описываем и создаем массив
// ИНициализация случаными числами
Random random = new Random(); // Объект типа Random

// заполнение массива
for (int i = 0; i < N; i++)
{
  for (int j = 0; j < M; j++)
  {
    a[i, j] = random.Next(1, 11);
  }
}
// вывод массива
for (int i = 0; i < N; i++)
{
  for (int j = 0; j < M; j++)
  {
    System.Console.Write($"{a[i, j]} ");
  }
  System.Console.WriteLine();
}

