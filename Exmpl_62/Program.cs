/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int count = 0;
ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
int mRow, nCol;
int[,] matrix;

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
    Console.ForegroundColor = colors[count];
    if (colors.Length - 1 == count)
    {
        count = 0;
    }
    Console.Write(text);
    Console.ResetColor();
}

void PrintArrayTwo(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); ++i)
    {
        for (int j = 0; j < collection.GetLength(1); ++j)
        {
            PrintColorData($"{collection[i, j]}\t");
        }
        Console.WriteLine();
        count++;
    }
}

/// Генерация матрицы методом рекурсии
/// first - начальное значение для заполнения матрицы (натуральное число)
/// step - шаг для заполнения матрицы (натуральное число)
/// row - номер строки матрицы
/// col - номер столбца матрицы 
void GenerateMatrixRecursive(int first, int step, int row, int col)
{
    if (row < mRow && row >= 0 && col < nCol && col >= 0)
    {
        if (matrix[row, col] == 0)
        {
            matrix[row, col] = first;
            first += step;
            if (row == 0 || matrix[row - 1, col] != 0)
                GenerateMatrixRecursive(first, step, row, col + 1);
            GenerateMatrixRecursive(first, step, row + 1, col);
            GenerateMatrixRecursive(first, step, row, col - 1);
            GenerateMatrixRecursive(first, step, row - 1, col);           
        }
    }
}

/// Генерация матрицы без рекурсии
/// first - начальное значение для заполнения матрицы (натуральное число)
/// step - шаг для заполнения матрицы (натуральное число)
/// m - кол-во строк матрицы
/// n - кол-во столбцов матрицы 
int[,] GenerateMatrix(int first, int step, int m, int n)
{
    int[,] arr = new int[m, n];
    int circle = 0;
    for (int i = 0; i < m - circle && first <= m * n * step; ++i)
    {
        if (i == circle)
        {
            // =>
            for (int j = circle; j < n - circle; ++j)
            {
                arr[i, j] = first;
                first += step;
            }
        }
        else
        {
            if (i == m - 1 - circle)
            {
                // <=
                for (int j = n - 1 - circle; j >= circle; --j)
                {
                    arr[i, j] = first;
                    first += step;
                }
                circle++;
                // /|\
                i = circle - 1;
                for (int k = m - 1 - circle; k >= circle && arr[k, i] == 0; --k)
                {
                    arr[k, i] = first;
                    first += step;
                }
            }
            else
            {
                // \|/
                if (arr[i, n - 1 - circle] == 0)
                {
                    arr[i, n - 1 - circle] = first;
                    first += step;
                }
            }
        }
    }
    return arr;
}

/*mRow = 0;
while (mRow < 1)
{
    mRow = StrToInt("Введите натуральное число - число строк массива: ");
}
nCol = 0;
while (nCol < 1)
{
    nCol = StrToInt("Введите натуральное число - число столбцов массива: ");
}
matrix = GenerateMatrix(1, 1, mRow, nCol);
PrintArrayTwo(matrix);
matrix = new int[mRow, nCol];
GenerateMatrixRecursive(1, 1, 0, 0);
Console.WriteLine($"Матрица {mRow} на {nCol} (рекурсия)");
count = 0;
PrintArrayTwo(matrix);*/

for (mRow = 1; mRow < 8; ++mRow)
{
    for (nCol = 1; nCol < mRow + 2; ++nCol)
    {
        matrix = GenerateMatrix(1, 1, mRow, nCol);
        PrintArrayTwo(matrix);
        matrix = new int[mRow, nCol];
        GenerateMatrixRecursive(1, 1, 0, 0);
        Console.WriteLine($"Матрица {mRow} на {nCol} (рекурсия)");
        count = 0;
        PrintArrayTwo(matrix);
        Console.WriteLine();
    }
}