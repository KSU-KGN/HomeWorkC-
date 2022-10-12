/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

void PrintColorData(string text)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(text);
    Console.ResetColor();
}

void PrintArrayTwo(int[,] collection)
{
    Console.Write($"\t");
    for (int i = 0; i < collection.GetLength(1); ++i)
    {
        PrintColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < collection.GetLength(0); ++i)
    {
        for (int j = 0; j < collection.GetLength(1); ++j)
        {
            if (j == 0)
            {
                PrintColorData($"{i}\t");
            }
            Console.Write($"{collection[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int RandomNum(int min, int max)
{
    int num = new Random().Next(min, max + 1);
    return num;
}

int[,] IncreaseMatrix(int[,] mas1, int[,] mas2)
{
    int[,] res = new int[mas1.GetLength(0), mas2.GetLength(1)];
    int inc;
    for (int i = 0; i < mas1.GetLength(0); ++i)
    {
        for (int k = 0; k < mas2.GetLength(1); k++)
        {
            inc = 0;
            for (int j = 0; j < mas1.GetLength(1); ++j)
            {
                inc += mas1[i, j] * mas2[j, k];
            }
            res[i, k] = inc;
        }
    }
    return res;
}

int[,] GenerateMatrix(int size)
{
    int m = 0;
    while (m < 1)
    {
        m = StrToInt("Введите натуральное число - число строк массива: ");
    }
    int n = 0;
    while (n < 1)
    {
        n = StrToInt("Введите натуральное число - число столбцов массива: ");
    }
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            arr[i, j] = RandomNum(-size, size);
        }
    }
    return arr;
}

int maxmin = 5;
int[,] matrix1 = GenerateMatrix(maxmin);
Console.WriteLine("Матрица первая:");
PrintArrayTwo(matrix1);
int[,] matrix2 = GenerateMatrix(maxmin);
Console.WriteLine("Матрица вторая:");
PrintArrayTwo(matrix2);
if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    int[,] res = IncreaseMatrix(matrix1, matrix2);
    Console.WriteLine("Результирующая матрица будет:");
    PrintArrayTwo(res);
}
else
{
    Console.WriteLine("Произведение двух матриц АВ имеет смысл только в том случае,\n" + 
                      "когда число столбцов матрицы А совпадает с числом строк матрицы В");
}