/*
Задача № 37
Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
*/
System.Console.WriteLine("Введите количество элементов массива...");
int N = int.Parse(Console.ReadLine());

int [] a = new int[N];
Random random = new Random();

int countEven = 0;
int countOdd = 0;

for (int i = 0; i < a.Length; i++) {
    a[i] = random.Next(100, 999);
    System.Console.Write($"{a[i]} ");

    if (a[i] % 2 == 0)
    {
        countEven ++;
    }
    else
    {
        countOdd ++;
    }
}
System.Console.WriteLine($"\nКоличество четных элементов равно: {countEven} \nКоличество нечетных элементов равно: {countOdd}");