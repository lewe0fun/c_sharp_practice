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
public static void print3DArr(int[,,]arr)
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
                do
                {
                    result[i, j, k] = new Random().Next(minValue, maxValue + 1); 
                }while(checkForRepInArr(result,result[i,j,k],i,j,k));
                

            }
        }
    }
    return result;
}
public static bool checkForRepInArr(int[,,]arr,int value,int ii, int jj, int kk)
{
    for (int i=0;i<ii;i++)
    {
        for (int j=0;j<jj;j++)
        {
            for (int k=0;i<kk;k++)
            {
                if(arr[i,j,k]==value)return true;
            }
        }
    }
    return false;
}
//Создание спиральной матрицы
public static int[,] getSpiralArr(int size)
{
	int[,] result = new int[size, size];
	int count = 1;

	for (int i = 1; i <= size / 2; i++)
	{
		for (int j = i - 1; j < size - i + 1; j++)
		{
			result[i - 1, j] = count++;
		}
		for (int j = i; j < size - i + 1; j++)
		{
			result[j, size - i] = count++;
		}
		for (int j = size - i - 1; j >= i - 1; --j)
		{
			result[size - i, j] = count++;
		}
		for (int j = size - i - 1; j >= i; j--)
		{
			result[j, i - 1] = count++;
		}
	}
	return result;
}

//Все натуральные числа в промежутке от M до N
public static void showDigitsBetween(int m,int n)
{
    if (n > m) showDigitsBetween(m,n-1);
    Write($"{n} ");
}
//Cумма натуральных элементов в промежутке от M до N
public static int sumBetween(int m, int n)
{
    if (n <= 0) return 0; 
    else if (n == m) return m;
    else return sumBetween(m, n - 1) + n; 
}
//Функция Аккермана
public static int ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return ackermann(m - 1, 1);
    }
    else
    {
        return ackermann(m - 1, ackermann(m, n - 1));
    }
}
}
