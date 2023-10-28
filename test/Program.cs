﻿/*
/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1) System.Console.Write(", ");// [5, 7, 1, 4

    }

    System.Console.Write("]");
}

int[] ProductArray(int[] arr)                // метод для перемножения пар чисел в одномерном массиве 
                                             // и передачи результатов перемножения в новый массив
{
    int size = 0;
    if (arr.Length % 2 == 1) size = arr.Length / 2 + 1;            // условие, при котором если в исходном массиве нечетное число элементов, 
    else size = arr.Length / 2;                    // чтобы при перемножении пар элементов, начиная с концов массива создать иллюзию
                                                   // перемножения центрального элемента самого на себя
    int[] res = new int[size];                    // создание нового массива, куда будут записаны результаты перемножения
    for (int i = 0; i < size; i++)
    {
        if ((arr.Length % 2 == 1) && (i == size - 1)) res[i] = arr[i];    // условие, при котором при нечетном количестве элементов исходного массива 
        else res[i] = arr[i] * arr[arr.Length - i - 1];        // средний его элемент будет приравнен к последнему элементу нового массива
    }
    return res;
}
int[] userArray = GetRandomArray(6);
PrintArray(userArray);
System.Console.WriteLine();
int[] newArray = ProductArray(userArray);
PrintArray(newArray);
