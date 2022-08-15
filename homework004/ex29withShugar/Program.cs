/*
 Задача 29:** Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

 6, 1, 33 -> [6, 1, 33]
*/

using static System.Console;
WriteLine($"[{String.Join(",", printArrOfLength(ReadLine()))}]");

int[] printArrOfLength(string stringArr)
{
    string[] massString = stringArr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] arr = new int[massString.Length];
    for (int i = 0; i < massString.Length; i++)
    {
        arr[i] = int.Parse(ReadLine());
    }
    return arr;
}