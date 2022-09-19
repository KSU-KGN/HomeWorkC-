bool WeekEnd(int num)
{
    if (num == 6 || num == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int num;
do
{
    Console.Write("Введите цифру дня недели (1, 2, 3 ... 7): ");
    num = Convert.ToInt32(Console.ReadLine());
}
while (num < 1 || num > 7);

if (WeekEnd(num))
{
    Console.WriteLine("да, это выходной");
}
else
{
    Console.WriteLine("нет, это не выходной");
}