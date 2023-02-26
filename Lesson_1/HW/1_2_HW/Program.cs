//Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

int max_number = a;

if (b > max_number)
    max_number = b;
if (c > max_number)
    max_number = c;
Console.WriteLine("Максимальное число " + max_number);
