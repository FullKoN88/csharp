/*
26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 526. 
*/

Console.Clear();
System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int Num(int a)
{

int count = 0;
/* if (userNumber < 0)
{
    userNumber = userNumber * -1;
}
*/
if (a == 0) 
    {
    count = 1;
    }
    if (a < 0)
    { 
    a = a * -1;
    }
for (int i = a; i > 0; i /= 10)
{
    count++;
}
return count;
}
int userResult = Num(userNumber);
Console.Clear();
System.Console.WriteLine($"В числе {userNumber} -> {userResult} цифры");
