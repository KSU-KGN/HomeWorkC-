/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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

int Acerman(int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    if (m > 0 && n == 0)
    {
        return Acerman(m-1, 1);
    }
    return Acerman(m-1, Acerman(m, n-1));
}

int numberM = -1;
while (numberM < 0)
{
    numberM = StrToInt("Введите неотрицательное число M:");
}
int numberN = -1;
while (numberN < 0)
{
    numberN = StrToInt("Введите неотрицательное число N:");
}
int res = Acerman(numberM, numberN);
Console.WriteLine($"Функция Аккермана А({numberM}, {numberN}) = {res}");