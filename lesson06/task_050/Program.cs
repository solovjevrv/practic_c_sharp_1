/*
Задача № 50
В двумерном массиве n×k заменить четные элементы на 
противоположные по значению (a[i,j]=-a[i,j])
*/

int[,] a;
a = GenerateArray(3, 2);
PrintArray(a);
System.Console.WriteLine();
Solution(a);
PrintArray(a);

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
int[,] GenerateArray(int N, int M)
{
  a = new int[N, M]; //описываем и создаем массив
                     // ИНициализация случаными числами
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
void Solution(int[,] a)
{
  for (int i = 0; i < a.GetLength(0); i++)
  {
    for (int j = 0; j < a.GetLength(1); j++)
    {
      if (a[i, j] % 2 == 0)
      {
        a[i, j] = -a[i, j];
      }
    }
  }
}