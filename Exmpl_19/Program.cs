int SuperProverka(int num, int razryd)
{   
    int count = 0;
    int newNum = 0;
    if (num < 0)
    {
        num = -num;
    }
    int saveNum = num; 

    while (num >= 1)
    {
        if (count < razryd)
        {
           newNum = newNum * 10 + num % 10;
        }
        num /= 10;
        count++;
    }

    if (count == razryd)
    {
        if ((saveNum - newNum) == 0)
        {
            return 2;
        }
        else
        {
            return 1;
        }
    }
    else
    {
        return 0;
    }
}

int StrToInt(string text, int razryd)
{
    int res, resultInput;
    string userLine;

    do
    {
        Console.WriteLine(text);
        userLine = Console.ReadLine();
        resultInput = 0;
        if (int.TryParse(userLine, out res))
        {
            resultInput = SuperProverka(res, razryd);
        }
    }
    while (resultInput == 0);
    return resultInput;
}

int numZnk = 5;
int num = StrToInt("Введите пятизначное число: ", numZnk);

if (num == 2)
{
    Console.WriteLine("Да, это палиндром");
}
else
{
    Console.WriteLine("Нет, это не палиндром");
}