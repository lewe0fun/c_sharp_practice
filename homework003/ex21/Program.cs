﻿/*
**Задача 21**Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
using static System.Console;
WriteLine("Ввекдите координату X1");
int x1 = int.Parse(Console.ReadLine());
WriteLine("Ввекдите координату Y1");
int y1 = int.Parse(Console.ReadLine());
WriteLine("Ввекдите координату Z1");
int z1 = int.Parse(Console.ReadLine());
WriteLine("Ввекдите координату X2");
int x2 = int.Parse(Console.ReadLine());
WriteLine("Ввекдите координату Y2");
int y2 = int.Parse(Console.ReadLine());
WriteLine("Ввекдите координату Z2");
int z2 = int.Parse(Console.ReadLine());

double c = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
WriteLine($"Рассстояние между этими точками равно: {c}");