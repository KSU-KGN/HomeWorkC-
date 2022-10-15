/*
Задача 64: Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
int StrToInt(string text)
{
    int res;
    string userLine;
    do
    {
        Console.WriteLine(text);
        userLine = Console.ReadLine();
    }
    while (int.TryParse(userLine, out res) == false);
    return res;
}

void PrintNums(int num)
{
    if (num == 0)
    {
        return;
    }
    if (num == 1)
    {
        Console.Write($"{num}");
    }
    else
    {
        Console.Write($"{num}, ");
    }
    PrintNums(num - 1);
}

int number = 0;
while (number < 1)
{
    number = StrToInt("Введите натуральное число:");
}
PrintNums(number);