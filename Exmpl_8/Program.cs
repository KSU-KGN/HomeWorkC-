Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Все чётные числа от 1 по {num}: ");
int sign = 1;
if (num < 0)
{
    num = -num;
    sign = -1;
}

int step = 2;
while (step <= num)
{
    Console.Write(sign * step);
    if (num - step > 1)
    {
        Console.Write(", ");
    }
    step += 2;
}