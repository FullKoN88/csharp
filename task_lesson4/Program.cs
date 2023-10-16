// // See https://aka.ms/new-console-template for more information24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
/*
Взять число, найти его квадрат и вычислить корень квадратный из получившегося числа.
*/

int userA = 4;

double Num(int a)
{
    double result = Math.Pow(a, 2);
    System.Console.WriteLine(result);
    return result;
}

// void Num1(int a)
// {
//     double result = Math.Pow(a, 2);
//     System.Console.WriteLine(result);
// }
// System.Console.WriteLine(Num(userA));
// double userresult = Num(userA);
// double root = Math.Sqrt(Num1(userA));
// System.Console.WriteLine(userresult);
// System.Console.WriteLine(root);
// Num1(userA);
