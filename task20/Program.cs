/*
Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/
Console.WriteLine();
System.Console.WriteLine("Введите координаты точки A (x, y): ");
int userAX = Convert.ToInt32(Console.ReadLine());
int userAY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B (x, y): ");
int userBX = Convert.ToInt32(Console.ReadLine());
int userBY = Convert.ToInt32(Console.ReadLine());

//int squareX = (userBx - userAx) * (userBX - userAX);

double squareX = Math.Pow(userBX - userAX, 2); // Функция возведения в степень.Math.Pow(a, 3), что возводим и в какую степень.
double squareY = Math.Pow(userBY - userAY, 2);
double rootXY = Math.Sqrt(squareX + squareY); // находит Корень квадратный Math.Sqrt(X+Y)
System.Console.WriteLine(Math.Round(rootXY, 2)); // Округление чисел после запятой Math.Round(число, ск чисел оставить после запятой)

