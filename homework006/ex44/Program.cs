
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2-> 2

//1, -7, 567, 89, 223-> 3

using static System.Console;

WriteLine("Сколько чисел вы хотите ввести?");
int length=int.Parse(ReadLine());
int[]digits=getArr(length);
printArr(digits);
printCount(digits);


void printCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    Write($" ->{count}");
}
void printArr(int[]arr)
{
    for (int i=0; i<digits.Length; i++)
    {
        Write(digits[i]);
        if (i < digits.Length - 1) Write(", ");
    }
    
}
int[] getArr(int length)
{
    int[] arr=new int[length];
    for (int i=0; i<length; i++)
    {
        WriteLine($"Число {i+1}");
        arr[i] = int.Parse(ReadLine());
    }
    return arr;
}