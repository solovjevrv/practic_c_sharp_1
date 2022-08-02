/*
Задача № 48
Написать программу копирования массива
*/
int[] Arr = { 5, 4, 7, 2, 9 };

int[] Copy = new int[Arr.Length];
for (int i = 0; i < Arr.Length; i++) {
    Copy[i] = Arr[i];
    Console.Write($"{Copy[i]} ");
}

