/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/
using Methods;
using static System.Console;

int[,] arr = mtd.getMatrixArr(4,4,0,9);
WriteLine("Задан массив: ");
mtd.printMatrixArr(arr);
mtd.printMinSumRow(arr);
