/*
Задача № 39
Найти сумму чисел одномерного массива стоящих на нечетной позиции
*/
System.Console.WriteLine("Введите количество элементов массива...");
int N = int.Parse(Console.ReadLine());

int [] a = new int[N];
Random random = new Random();

int sum = 0;

for (int i = 0; i < a.Length; i++) {
    a[i] = random.Next(1, 10);
    System.Console.Write($"{a[i], 2}");

    if (i % 2 != 0)
    {
        sum += a[i];
    }
}
System.Console.WriteLine($"\n{sum}");



