/*
Задача № 36
В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
*/

int [] a = new int[8] {-1, 2, 3, 4, -5, 6, 7, 8};
int maxNum = a.Max();
int minNum = a.Min();
for (int i = 0; i < a.Length; i++) {
    System.Console.Write($"{a[i]} ");
}
System.Console.WriteLine($"\n{maxNum - minNum}");