/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
using static System.Console;
using Methods;

WriteLine("Введите число M:");
int m=int.Parse(ReadLine());
WriteLine("Введите число N:");
int n = int.Parse(ReadLine());
WriteLine($"Cумма натуральных элементов в промежутке от M до N: {mtd.sumBetween(m, n)}");