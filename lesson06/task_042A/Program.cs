/*

Задача № 42A

Даны две квадратных таблицы чисел. Требуется построить третью,
каждый элемент которой равен сумме элементов, стоящих на том же месте
в 1-й и 2-й таблицах.

Входные данные
Во входном файле записано сначала число N, затем записана первая таблица,
а после нее - вторая. Элементы таблиц - числа от 0 до 100.
100>=N>=1.
*/
int[,] a;
int[,] b;
int[,] c;
int[,] Array_1 = GenerateArray(4);
System.Console.WriteLine("Первая матрица чисел");
PrintArray(Array_1);
System.Console.WriteLine("Вторая матрица чисел");
int[,] Array_2 = GenerateArray(4);
PrintArray(Array_2);
System.Console.WriteLine("Сумма матриц");
int[,] Array_3 = SumArray(Array_1, Array_2);
PrintArray(Array_3);

// вывод массива
void PrintArray(int[,] a)
{
  for (int i = 0; i < a.GetLength(0); i++)
  {
    for (int j = 0; j < a.GetLength(1); j++)
    {
      System.Console.Write($"{a[i, j]} ");
    }
    System.Console.WriteLine();
  }
}

// заполнение массива
int[,] GenerateArray(int N)
{
  a = new int[N, N]; //описываем и создаем массив
  Random random = new Random(); // Объект типа Random
  for (int i = 0; i < a.GetLength(0); i++)
  {
    for (int j = 0; j < a.GetLength(1); j++)
    {
      a[i, j] = random.Next(1, 10);
    }
  }
  return a;
}

// решение задачи
int[,] SumArray(int[,] a, int[,] b)
{
  c = new int[a.GetLength(0), a.GetLength(1)];
  for (int i = 0; i < c.GetLength(0); i++)
  {
    for (int j = 0; j < c.GetLength(1); j++)
    {
      c[i, j] = a[i, j] + b[i, j];
    }
  }
  return c;
}