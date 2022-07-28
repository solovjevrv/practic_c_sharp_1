/*
Задача № 35
Написать программу замены элементов массива на противоположные
*/

int [] a = new int[10] {0,1,2,3,4,5,6,7,8,9};
int [] b = new int[10];
for (int i = 0; i < a.Length; i++)
{
    System.Console.Write($"{a[i]} ");    
    b[i] = a[a.Length - i -1];
    
}
System.Console.WriteLine("Измененный массив:");

for (int i = 0; i < b.Length; i++)
{
    System.Console.Write($"{b[i]} ");  
    
}
