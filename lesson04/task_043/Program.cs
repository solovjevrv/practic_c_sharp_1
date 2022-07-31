/*
Задача № 43
С клавиатуры вводится число N. Затем вводятся N чисел. 
Определить сколько чисел больше 0 введено с клавиатуры
*/
int N = 0;
int count = 0;
System.Console.WriteLine($"Введено {counterNum(N)} чисел больше 0");
int counterNum (int num)
{
    System.Console.WriteLine("Сколько чисел будем вводить...");
    N = int.Parse(Console.ReadLine());

    while (N != 0)
    {   
        System.Console.WriteLine("Введите число: ");
        int temp = int.Parse(Console.ReadLine());
        if (temp > 0) 
            count ++;
        N --;
    }
    return count;
}
