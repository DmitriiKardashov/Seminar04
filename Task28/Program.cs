
int Factorial(int num)
{
    int sum = 1;
    for(int i = 1; i <= num; i++)
    checked
    {
        sum = sum * i;
    }
    return sum;   
}

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number>0)
{
    int factorial = Factorial(number);
    Console.WriteLine($"{number} -> {factorial}");
}
else
{
    Console.WriteLine("Некорректный ввод");
}