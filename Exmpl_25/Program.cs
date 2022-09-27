/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
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

int MyPow(int A, int B)
{
    int res = A;
    for (int i = 2; i <= B; ++i)
    {
        res *= A;
    }
    return res;
}

int numA = StrToInt("Введите число A: ");
int numB; 
do
{
    numB = StrToInt("Введите натуральное число B: ");  
}
while (numB < 1);
int result = MyPow(numA, numB);
Console.WriteLine($"Число {numA} в натуральной степени {numB} равно {result}");