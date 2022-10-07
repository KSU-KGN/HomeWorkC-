/*
Задача 50. Напишите программу, которая на вход принимает 
позицию элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9
индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4
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

string FoundElementFromPosition(int[,] array, int m_row, int n_col, int pos)
{
    string result = "";
    int row = pos / n_col;
    int col = pos % n_col;
    if (row >= m_row || col >= n_col)
    {
        result = "такого числа в массиве нет";
    }
    else
    {
        result = "позиции " + pos + " соответствует элемент массива [" + row + ", " + col + "]\n" + 
                 "значение этого элемента равно " + array[row, col];
    }
    return result;
}

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
        arr[i, j] = RandomNum(-10, 10);
    }
}
PrintArrayTwo(arr);
int position = -1;
while (position < 0)
{
    position = StrToInt("Введите позицию элемента в двумерном массиве: ");
}
string res = FoundElementFromPosition(arr, m, n, position);
Console.WriteLine(res);