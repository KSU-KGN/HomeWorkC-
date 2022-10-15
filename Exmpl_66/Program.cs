/*
Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

int SumNums(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return n + SumNums(m, n-1);
}

int numberM = 0;
while (numberM < 1)
{
    numberM = StrToInt("Введите натуральное число M:");
}
int numberN = 0;
while (numberN < 1)
{
    numberN = StrToInt("Введите натуральное число N:");
}
if (numberN < numberM)
{
    int tmp = numberM;
    numberM = numberN;
    numberN = tmp;
}
int res = SumNums(numberM, numberN);
Console.WriteLine($"Cумма натуральных элементов в промежутке от {numberM} до {numberN} = {res}");