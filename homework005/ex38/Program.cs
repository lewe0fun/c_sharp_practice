/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/

using static System.Console;

float[] arr = new float[5];

fillArr(arr);
WriteLine($"[{String.Join(" ", arr)}]-> {nimMaxDiff(arr)}");

void fillArr(float[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99,100);
    }
}
float nimMaxDiff(float[] arr)
{
    float min,max;
    max = min = arr[0];
    for(int i=0;i<arr.Length;i++)
    {
        if (arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
    }
    return max-min;
}