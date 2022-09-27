/*
Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
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

int SumFromNumber(int num)
{   
    int res = 0;
    num = Math.Abs(num);
    while (num >= 1)
    {
        res += num % 10;
        num /= 10;
    }
    return res;
}

int number = StrToInt("Введите число: ");
int result = SumFromNumber(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {result}");