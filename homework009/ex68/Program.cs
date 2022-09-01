/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/
using Methods;
using static System.Console;

WriteLine("Введите число M:");
int m=int.Parse(ReadLine());
WriteLine("Введите число N:");
int n = int.Parse(ReadLine());
WriteLine($"m = {m}, n = {n} -> A(m,n) = {mtd.ackermann(m, n)}");