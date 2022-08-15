/*Задача 25:**Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4-> 16*/
using static System.Console;
WriteLine("Введте число А и В");
int a=getIngeger(); 
int b=getIngeger();
WriteLine($"Число А={a} в степени В={b} равно: {pow(a,b)}");

int getIngeger()
{
    Write("введите число: ");
    return int.Parse(ReadLine());
}
int pow(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    return result;
}