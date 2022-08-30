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
//Создание заполненного двумерного массива
    public static int[,] getMatrixArr(int rows, int colums, int minValue, int maxValue)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
// заполнение одномерного массива int переменными от minValue до maxValue
public static void fillArray(int[]arr,int minValue,int maxValue)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue,maxValue+1);
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
public static int digitCount(int digit)
{
    int counter = 0;
    while (digit != 0)
    {
        digit /= 10;
        counter++;
    }
    return counter;
}
//сортировка по убыванию строк двумерного массива
public static void sortMatrixRows(int[,]arr)
{
    int count;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        count = arr.GetLength(0);
        while (count > 0)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[i,j] < arr[i,j + 1]) swap(ref arr[i,j], ref arr[i,j + 1]);
            }
            count--;
        }
    }
}
//вывод в консоль двумерного массива
public static void printMatrixArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j]} ");
        }
        Write("\n");
    }
}
// вывод нормер строки с минимальной суммой элементов
public static void printMinSumRow(int[,] arr)
{
    int[] elementsSum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            elementsSum[i] += arr[i, j];
        }
    }
    int min=elementsSum[0];
    int minValueIndex = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (min > elementsSum[i])
        {
            min = elementsSum[i];
            minValueIndex = i;
        }
            
    }
    WriteLine($"{minValueIndex+1} строка имеет минимальную сумму элементов: {min}");
}
//Умножение матриц
public static int[,] multiplyMatrix(int[,] arr1,int[,]arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                for (int k = 0; k < result.GetLength(0); k++)
                {
                    result[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
    }
    else
    { 
        WriteLine("Матрици умножить нельзя");
    }
    return result;
}
//Вывод трехмерного массива построчно
public static void printget3DArr(int[,,]arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                WriteLine($"{arr[i,j,k]}({i},{j},{k})");
            }
        }
    }
}
//Создание трехмерного массива
public static int[,,] get3DArr(int x, int y,int z, int minValue, int maxValue)
{
    int[,,] result = new int[x,y,z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}
//
public static int[,] getSpiralArr(int size)
{
	int[,] result = new int[size, size];
	int count = 1;

	for (int k = 1; k <= size / 2; k++)
	{
		for (int j = k - 1; j < size - k + 1; j++)
		{
			result[k - 1, j] = count++;
		}
		for (int j = k; j < size - k + 1; j++)
		{
			result[j, size - k] = count++;
		}
		for (int j = size - k - 1; j >= k - 1; --j)
		{
			result[size - k, j] = count++;
		}
		for (int j = size - k - 1; j >= k; j--)
		{
			result[j, k - 1] = count++;
		}
	}
	return result;
}
}
