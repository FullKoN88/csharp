/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели от 1 до 7: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber <=5)
{
Console.WriteLine("Будни");
}
if (dayNumber == 6 || dayNumber == 7)
{
Console.WriteLine("Выходной");
}
if (dayNumber == 1)
{
    Console.WriteLine("Понедельник");
}
else if (dayNumber == 2)
{
    Console.WriteLine("Вторник");
}
else if (dayNumber == 3)
{
    Console.WriteLine("Среда");
}
else if (dayNumber == 4)
{
    Console.WriteLine("Четверг");
}
else if (dayNumber == 5)
{
    Console.WriteLine("Пятница");
}
else if (dayNumber == 6)
{
    Console.WriteLine("Суббота");
}
else if (dayNumber == 7)
{
    Console.WriteLine("Воскресенье");
}
    else Console.WriteLine("Такого дня не существует!");



