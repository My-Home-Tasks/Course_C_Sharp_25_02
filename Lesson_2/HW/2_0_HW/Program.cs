//Задача 1: Напишите программу, которая принимает на вход трёхзначное
//число и на выходе показывает вторую цифру этого числа.

int TakeSecond(int num)
{
    Console.WriteLine(num);
    int Second = (num / 10) % 10;
    return Second;
}

int itog = TakeSecond(new Random().Next(100, 1000));
Console.WriteLine(itog);