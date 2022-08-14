/*
Задача 004 (из сервиса преподавателя)
В матрице найти номер строки, сумма чисел в которой максимальна
*/
string s = Console.ReadLine();
int N = int.Parse(s.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
int M = int.Parse(s.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);

int[,] a = new int[N, M];

for (int i = 0; i < N; i++)
{
  s = Console.ReadLine();
  string[] ss = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
  for (int j = 0; j < ss.Length; j++)
  {
    a[i, j] = int.Parse(ss[j]);
  }
}

int mini = 0;
int maxj = 0;
int min = a[0, 0];

for (int i = 0; i < a.GetLength(0); i++)
{
  for (int j = 0; j < a.GetLength(1); j++)
  {
    if (a[i, j] < min)
    {
      min = a[i, j];
      mini = i;
      minj = j;
    }
  }

}
System.Console.WriteLine(a[mini, minj]);