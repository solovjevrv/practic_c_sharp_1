/**
Задача № 27
Возведите число А в натуральную степень B используя цикл
*/

System.Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());
int exp = 1;
int getExp (int A, int B)
{
    for (int i = 1; i<=B; i++)
    {
        exp *= A;
    }
    return exp;

}
System.Console.WriteLine($"Число А в степени В равно: {getExp(A, B)}");

