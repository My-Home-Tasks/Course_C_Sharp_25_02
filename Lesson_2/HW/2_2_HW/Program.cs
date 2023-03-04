//Задача 3: Напишите программу, которая выводит третью 
//цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdRank(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}

bool Validate (int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}    

int num = int.Parse(Console.ReadLine()!);
if (Validate(num))
{
    Console.WriteLine(ThirdRank(num));
}

