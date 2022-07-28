/*
Задача № 32
Задать массив из 8 целых элементов и вывести их на экран
*/

// int[] t;
// t = new int[8];
// for (int i = 0; i < t.Length; i++)
// {
//     t[i] = i * 10;
//     System.Console.Write($"t[{i}]={t[i]} ");
// }
int [] arr; 
Init(out arr, 8, 0, 10);
Print(arr);

void Init (out int[] arr, int Length, int min, int max)
{
    arr = new int [Length];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(min, max+1);
    }
}

void Print (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write($"{arr[i]} ");
}
}