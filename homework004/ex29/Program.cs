/*
 Задача 29:** Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

 6, 1, 33 -> [6, 1, 33]
*/

using static System.Console;
printArrOfLength(8);


void printArrOfLength(int Length)
{
    int[] arr = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        WriteLine($"Введите {i+1} элемент массива");
        arr[i] = int.Parse(ReadLine());
    }
    Write("[");
    for (int i = 0; i < Length; i++)
    {
        Write(arr[i]);
        if (i < arr.Length - 1) Write(", ");
    }
    Write("]");
}