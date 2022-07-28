/*
Задача № 34
Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
Найти сумму положительных/отрицательных элементов массива
*/

int [] arr;
Init(out arr, 12, -9, 9);
Print(arr);

int sumPos;
int sumNeg;

Solve(arr, out sumPos, out sumNeg);
System.Console.WriteLine($"\nСумма положительных элементов массива равна: {sumPos}");
System.Console.WriteLine($"Сумма отрицательных элементов массива равна: {sumNeg}");
// инициализация массива
void Init (out int[] arr, int Length, int min, int max)
{
    arr = new int [Length];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(min, max+1);
    }
}
// вывод массива
void Print (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");

    }
}
// решение задачи
void Solve (int [] arr, out int sumPos, out int sumNeg)
{
    sumPos = 0;
    sumNeg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumPos += arr[i];
        }
        else 
        {
            sumNeg += arr[i];
        }
    }
}