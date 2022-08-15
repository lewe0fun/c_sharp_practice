﻿/*Задача 27:** Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

using static System.Console;
Write("Введите число: ");
WriteLine($"Сумма цифр в числе равна: {sum(int.Parse(ReadLine()))}");

int sum(int digit)
{
    int result = 0;
    while (digit != 0)
    {
        result+=digit%10;
        digit /= 10;
    }
    return result;
}