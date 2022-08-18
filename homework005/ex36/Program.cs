/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/

using static System.Console;

int[] arr = new int[4];
fillArr(arr);
WriteLine($"[{String.Join(",", arr)}]-> {oddSum(arr)}");

void fillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-50,51);
    }
}
int oddSum(int[] arr)
{
    int sum = 0;
    for(int i=0;i<arr.Length;i++)
    {
        if (i % 2 != 0) sum += arr[i];
    }
    return sum;
}