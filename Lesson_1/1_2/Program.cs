// 2. Напишите программу, которая будет выдавать название дня
// недели по заданному номеру.
string a_s = Console.ReadLine()!;

if (a_s == "1")
{
    Console.WriteLine("Пн");
}
else if (a_s == "2")
{
    Console.WriteLine("Вт");
}
else if (a_s == "3")
{
    Console.WriteLine("Ср");
}
else if (a_s == "4")
{
    Console.WriteLine("Чт");
}
else if (a_s == "5")
{
    Console.WriteLine("Пт");
}
else if (a_s == "6")
{
    Console.WriteLine("Сб");
}
else if (a_s == "7")
{
    Console.WriteLine("Вс");
}
else
{
    Console.WriteLine("Ошибка");
}
