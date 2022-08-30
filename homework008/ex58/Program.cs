/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

using Methods;
using static System.Console;

int[,] arr1 = mtd.getMatrixArr(2,2,0,9);
int[,] arr2 = mtd.getMatrixArr(2,2,0,9);

WriteLine("даны 2 матрицы: ");
mtd.printMatrixArr(arr1);
Write("\n");
mtd.printMatrixArr(arr2);
WriteLine("Результирующая матрица будет: ");
mtd.printMatrixArr(mtd.multiplyMatrix(arr1, arr2));