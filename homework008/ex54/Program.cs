/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
using Methods;
using static System.Console;

int[,] arr = mtd.getMatrixArr(3,4,0,9);
WriteLine("Задан массив: ");
mtd.printMatrixArr(arr);
mtd.sortMatrixRows(arr);
WriteLine("В итоге получается вот такой массив: ");
mtd.printMatrixArr(arr);
