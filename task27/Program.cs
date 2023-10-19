/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


System.Console.WriteLine("Введите число: ");

int Num(int a)
{
    int result = 0;
    for (int i = a; i > 0; i /= 10)
    {
        result = result + i % 10;
    }
    return result;
}
int num = Convert.ToInt32(Console.ReadLine());
int userRes = Num(num);
System.Console.WriteLine(userRes);

