/*

Задача № 41A

Дана квадратная матрица. Проверить, является ли она симметричной относительно
главной диагонали.
*/

int[,] a;
int[,] SymmetryMatrix = new int[4, 4]; // симметричная матрица заполненная нулями для проверки
a = GenerateArray(4);
System.Console.WriteLine($"Матрица с рандомными числами:");
PrintArray(a);
Solution(a);
System.Console.WriteLine("---------");
System.Console.WriteLine($"Матрица для проверки:");
PrintArray(SymmetryMatrix);
Solution(SymmetryMatrix);
// PrintArray(a);

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
  bool flag = true;
  for (int i = 0; i < a.GetLength(0); i++)
  {
    for (int j = 0; j < a.GetLength(1); j++)
    {
      if (a[i, j] != a[j, i])
      {
        flag = false;
        // System.Console.WriteLine($"{a[i, j]} {a[j, i]}");
      }
    }
  }
  if (flag == true) System.Console.WriteLine("Матрица является симметричной");
  else System.Console.WriteLine("Матрица не является симметричной");
}