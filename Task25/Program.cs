/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/


int DegOfNumbers(int x, int y)
{
    int z = 1;
    if (y >0)
    {
        for (int i = 1; i <= y; i++)
        {
         z = z*x;
        }
     return z;
    }
    else return 0;
}

Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое положительное число");
int B = Convert.ToInt32(Console.ReadLine());

int res = DegOfNumbers(A, B);
Console.WriteLine($"{A} в степени {B} равно {res}");