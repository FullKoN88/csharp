/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
System.Console.WriteLine("Введите число A: ");
int userA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int userB = Convert.ToInt32(Console.ReadLine());

void Natural(int a, int b)
{
    double result = Math.Pow(a, b);
    System.Console.WriteLine(result);
}
Natural(userA, userB);
*/

System.Console.WriteLine("Введите число A: ");
int userA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int userB = Convert.ToInt32(Console.ReadLine());

void Natural(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    System.Console.WriteLine(result);
}
Natural(userA, userB);