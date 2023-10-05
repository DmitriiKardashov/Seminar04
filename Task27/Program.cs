/*Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int CountDigit(int num)
{
    if (num < 0) num = num*-1;
    if (num/10 < 0) return num;
    int res = 0;
    while (num > 0)
    {
        res = res + num%10;
        num = num/10;
    }
    return res;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int countDigit = CountDigit(number);
Console.WriteLine($"{number} -> {countDigit}");