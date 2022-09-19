int LengthNum(int num)
{
    int count = 0;

    while (num >= 1)
    {
        num /= 10;
        count++;
    }

    return count;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int len = LengthNum(num);
if (len < 3)
{
    Console.WriteLine($"третьей цифры у числа {num} нет");
}
else
{
    int res = num;
    for (int i = len; i > 3; i--)
    {
        res /= 10;
    }
    Console.WriteLine($"третья цифра у числа {num} равна {res % 10}");
}