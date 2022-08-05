/* **Задача 8:** Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5  -> 2, 4
8  -> 2, 4, 6, 8 */
using static System.Console;
Write("Введите целое число: ");
int n=int.Parse(ReadLine());
Write("-> ");
for (int i = 1; i < n; i++)
if(!Convert.ToBoolean(i%2))Write($"{i}, ");
Write("\n");