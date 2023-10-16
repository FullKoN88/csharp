/*
напишите метод DistanceBetweenPoints,
 который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел, 
 и возвращает расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();
System.Console.Write("Ведите координаты точки A (x, y, z): ");

int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
int userAz = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Ведите координаты точки B (x, y, z): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());
int userBz = Convert.ToInt32(Console.ReadLine());

double squareX = Math.Pow(userBx - userAx, 2);
double squareY = Math.Pow(userBy - userAy, 2);
double squareZ = Math.Pow(userBz - userAz, 2);
double result = Math.Sqrt(squareX + squareY + squareZ);

System.Console.WriteLine(Math.Round(result, 2));
Console.Clear();
System.Console.WriteLine($"Длина отрезка: {Math.Round(result, 2)}");