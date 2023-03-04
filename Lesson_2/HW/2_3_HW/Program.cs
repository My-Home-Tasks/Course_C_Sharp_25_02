//Задача 4: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

bool IsWeekend(int weekday)
{
    if (weekday > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekDay(int number)
{
    if (number > 0 && number <=7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели");
    return false;
}

int weekday = int.Parse(Console.ReadLine()!);
if (ValidateWeekDay(weekday))
{
    if (IsWeekend(weekday))
    {
        Console.WriteLine("Выходной");
    }
    else
    {
       Console.WriteLine("Рабочий"); 
    }
}