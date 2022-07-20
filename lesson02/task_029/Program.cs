/**
Задача № 29
Подсчитать сумму цифр в числе
*/

System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;

int sumDigit (int num)
{
    if (num != 0) 
    {
        while (num > 0)
        {
						int last_digit = num % 10;
            num = num / 10;
            sum += last_digit;

        }
        return sum;
    }
    else return num;

}
System.Console.WriteLine(sumDigit(num));

