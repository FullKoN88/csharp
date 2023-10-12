/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

System.Console.WriteLine("Введите число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (int i = userNumber1; i > 100; i = i / 10)
{
result = i % 10;
}
if (userNumber1 < 100)
{
System.Console.WriteLine("Третьей цифры нет");
}
else
{
System.Console.WriteLine(result);    
}





