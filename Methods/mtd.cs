using System;
using static System.Console;
namespace Methods;
public class mtd
{
    //свап int переменных
public static void swap(ref int a, ref int b)
{
int temp=a;
a=b;
b=temp;
}
// заполнение одномерного массива int переменными от 10 до 99
public static void fillArray(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(10,99);
    }
}
//сортировка одномерного массива методом выбора
public static void sortArray(int[] arr)
{
for (int i = 0; i < arr.Length-1; i++)
{
    for (int j = i+1; j < arr.Length; j++)
    {
        if(arr[j]<arr[i])swap(ref arr[j],ref arr[i]);
    }
}
}
//вывод в консоль одномерного массива
public static void printArr(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($" {arr[i]}");
        if((i!=0)&&(!Convert.ToBoolean(i%10)))Write("\n");
    }Write("\n");
}
//подсчет кол-ва цыфр
int digitCount(int digit)
{
    int counter = 0;
    while (digit != 0)
    {
        digit /= 10;
        counter++;
    }
    return counter;
}
}
