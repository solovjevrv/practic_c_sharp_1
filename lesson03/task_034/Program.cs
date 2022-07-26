/*
Задача № 34
Задать массив из 12 элементов, заполненных числами из [-9, 9]. Найти сумму положительных/отрицательных элементов массива
*/

int N = 12;
int [] a = new int[N];
Random random = new Random();

for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(-9, 10);

for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i]} ");
    System.Console.WriteLine();

int sumPos = 0;
for (int i = 0; i < a.Length; i++)
    if (a[i] > 0)
        sumPos += a[i];

System.Console.WriteLine(sumPos);

int sumNeg = 0;
for (int i = 0; i < a.Length; i++)
    if (a[i] < 0)
        sumNeg += a[i];

System.Console.WriteLine(sumNeg);


