﻿//Задача 2. Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа.

int TakeNum(int num)
{
    Console.WriteLine(num);
    int Second = ((num / 100) * 10) + (num % 10) ;
    return Second;
}

int itog = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(itog);

