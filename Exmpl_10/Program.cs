bool Proverka(int num)
{
    int count = 0;

    while (num >= 1)
    {
        num /= 10;
        count++;
    }

    if (count == 3)
    {
        return false;
    }
    else
    {
        return true;
    }
}

int num;
do
{
    Console.Write("Введите трёхзначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}
while (Proverka(num));

Console.WriteLine($"вторая цифра числа {num} равна {num / 10 % 10}");