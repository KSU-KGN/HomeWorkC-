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

int num = StrToInt("Введите число:");
int znk;
if (num < 0)
{
    znk = -1;
}
else
{
    znk = 1;    
};
int absNum = znk * num;
int step = 1;
int res;

while (step < absNum)
{
    res = znk * step * step * step;
    Console.Write($"{res}, ");
    step++;
}
res = znk * step * step * step;
Console.Write(res);