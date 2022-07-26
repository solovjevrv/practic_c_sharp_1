/*
Задача № 36
Определить, присутствует ли в заданном массиве, некоторое число
*/
System.Console.WriteLine("Введите количество элементов массива...");
int N = int.Parse(Console.ReadLine());
System.Console.WriteLine("Какое число нужно найти в массиве? Введите число...");
int F = int.Parse(Console.ReadLine());

int [] a = new int[N];
Random random = new Random();

for (int i = 0; i < a.Length; i++) {
    a[i] = random.Next(1, 10);
    System.Console.Write($"{a[i], 2}");
}

int j = 0;
while (j < a.Length && a[j] == F) j++;
if (j==a.Length) System.Console.WriteLine($"\n Данное число не найдено");
else System.Console.WriteLine($"\n Число {F} найдено в массиве");

