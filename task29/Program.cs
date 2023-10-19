/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] GetArray(int first, int second, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(first, second++);
        return array;
    }
}
void PrintArray(int[] arr)
{
    Console.ForgegroundColor-ConsoleColor.Red;
    System.Console.WriteLine("{");
    for (int i = 0; i < length; i++)
    {
        
    }
}
{
    for (int i = 0; i < arr.Lenght; i++)
    {
        System.Console.WriteLine($"{arr[i]},");
    }
}

System.Console.WriteLine("Введите колличество от: ");
int userFirst = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите колличество до: ");
int userSecond = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите диапозон: ");
int userSize = Convert.ToInt32(Console.ReadLine());

GetArray(userFirst, userSecond, userSize);