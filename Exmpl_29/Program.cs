/*
Задача 29: Напишите программу, в которой пользователь задает длину массива, 
элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
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

int randomNum(int min, int max)
{
    int num = new Random().Next(min, max + 1);
    return num;
}

void PrintArray(int[] collection)
{
    Console.Write("[");
    int index;
    for (index = 0; index < collection.Length - 1; index++)
    {
        Console.Write($"{collection[index]}, ");
    }
    Console.WriteLine($"{collection[index]}]");
}

int number;
do
{
    number = StrToInt("Введите натуральное число - длину массива: ");
}
while (number < 1);
int[] arr = new int[number];
for (int i = 0; i < number; i++)
{
    arr[i] = randomNum(1, 99);
}
PrintArray(arr);