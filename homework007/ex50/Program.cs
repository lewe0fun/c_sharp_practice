//Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17->такого числа в массиве нет

using static System.Console;

Write("Строк в массиве:");
int m=int.Parse(ReadLine());
Write("Столбцов в массиве:");
int n = int.Parse(ReadLine());
double[,]arr=new double[m,n];
Write("Какое число найти в массиве:");
int digit=int.Parse(ReadLine());
fillArr(arr);
printArr(arr);
printArrDigit(arr,digit);

void fillArr(double[,]arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Random x = new Random();
            arr[i, j] = x.Next(10);

        }
    }
}
void printArr(double[,] arr)
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
void printArrDigit(double[,] arr,int digit)
{
    int checkCounter = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == digit) WriteLine($"Число {digit} нашлось в {i + 1} сттроке и {j + 1} столбце");
            else checkCounter++;
        }
    }
    if (checkCounter == arr.Length) WriteLine("Нет такого числа");
}