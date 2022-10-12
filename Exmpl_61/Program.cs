/*
Задача 61: Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника
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

void PrintArrayTwo(int[,] collection, int num)
{
    int newNum = 2 * num - 1;
    for (int i = 0; i < collection.GetLength(0); ++i)
    {
        for (int j = 0; j < num - 1- i; ++j)
        {
            Console.Write("\t");
        }
        for (int j = 0; j < collection.GetLength(1); ++j)
        {
            if (collection[i, j] != 0)
            {
                Console.Write($"{collection[i, j]}\t\t");
            }
        }
        Console.WriteLine();
    }
}

int[,] trianglePascal(int num)
{
    int[,] res = new int[num, num];
    for (int i = 0; i < num; ++i)
    {
        res[i, 0] = 1;
        for (int j = 1; j <= i; ++j)
        {
            if (i > 0)
            {
                res[i, j] = res[i-1, j] + res[i-1, j-1];
            }
        }
    }
    return res;
}

Console.Clear();
int nStr = 0;
while (nStr < 1)
{
    nStr = StrToInt("Введите натуральное число - число строк треугольника Паскаля: ");
}
int[,] triangle = trianglePascal(nStr);
PrintArrayTwo(triangle, nStr);