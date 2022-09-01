/*
 Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""
*/
using static System.Console;
using Methods;
WriteLine("Введите число M:");
int m=int.Parse(ReadLine());
WriteLine("Введите число N:");
int n = int.Parse(ReadLine());
WriteLine("Все натуральные числа в промежутке от M до N:");
mtd.showDigitsBetween(m, n);
