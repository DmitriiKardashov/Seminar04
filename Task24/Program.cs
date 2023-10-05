
int SumNumbers(int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    checked
    {
        sum = sum + i;
    }
    return sum;   
}

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number>0)
{
    int sumNumbers = SumNumbers(number);
    Console.WriteLine($"{number} -> {sumNumbers}");
}
else
{
    Console.WriteLine("Некорректный ввод");
}