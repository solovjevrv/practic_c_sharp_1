/*
Задача № 32
Задать массив из 8 целых элементов и вывести их на экран
*/

int[] t;
t = new int[8];
for (int i = 0; i < t.Length; i++)
{
    t[i] = i * 10;
    System.Console.Write($"t[{i}]={t[i]} ");
}
