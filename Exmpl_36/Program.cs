/*

Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int NumToMas(int min, int max)
{
    int res = new Random().Next(min, max + 1);
    return res;
}

void PrintArray(int[] collection)
{
    Console.Write("[");
    int index;
    for (index = 0; index < collection.Length-1; index++)
    {
        Console.Write($"{collection[index]}, ");
    }
    Console.WriteLine($"{collection[index]}]");
}

int SumOddPosition(int[] mass, int size)
{
    int sum = 0;
    for (int i = 0; i < size; ++i)
    {
        if (i % 2 != 0)
        {
            sum += mass[i];
        }
    }
    return sum;
}

int userCount = StrToInt("Введите размер массива: ");
int[] myMass = new int[userCount];
for (int i = 0; i < userCount; ++i)
{
    myMass[i] = NumToMas(-100, 100);
}
PrintArray(myMass);
int res = SumOddPosition(myMass, userCount);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {res}");