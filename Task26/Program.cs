
int CountDigit(int num)
{
    if (num == 0) return 1;
    int count = 0;
    while (num != 0)
    {
        num = num/10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int countDigit = CountDigit(number);
Console.WriteLine($"{number} -> {countDigit}");