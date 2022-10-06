/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
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

double FoundX(int k1, int b1, int k2, int b2)
{
    double x = (double)(b2 - b1) / (k1 - k2);
    return x;
}

double FoundY(int k1, int b1, double x)
{
    double y = k1 * x + b1;
    return y;
}

int b1 = StrToInt("Введите число b1: ");
int k1 = StrToInt("Введите число k1: ");
int b2 = StrToInt("Введите число b2: ");
int k2 = StrToInt("Введите число k2: ");
double num_x = FoundX(k1, b1, k2, b2);
double num_y = FoundY(k1, b1, num_x);
Console.WriteLine($"Точкой пересечения двух прямых, заданных уравнениями:\ny = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine($"является точка с координатами ({num_x}; {num_y})");