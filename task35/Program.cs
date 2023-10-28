/*
35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] RandomArray()
{
    int[] array = new int[5];
    for (int i = 0; i < 5; i++)
    {
        array[i]= new Random().Next(10, 100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}

int FindNumb(int[] arrayFirst)
{
    int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
        if (arrayFirst[i] >= 10 && arrayFirst[i] <= 99)
        count++;
    }
    return count;
}
int[] userArray = RandomArray();
PrintArray(userArray);
System.Console.WriteLine();
System.Console.WriteLine(FindNumb(userArray));