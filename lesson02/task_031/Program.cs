/*
Задача № 31
Показать кубы чисел, заканчивающихся на четную цифру
т. к. не задан диапазон чисел, выберем произвольный [1: N]
*/

System.Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int cubeN;
for (int i = 1; i <= N; i++)
{
	cubeN = i*i*i;
    if (cubeN % 10 % 2 == 0)
    {
        System.Console.WriteLine(cubeN);
    }
   
}
