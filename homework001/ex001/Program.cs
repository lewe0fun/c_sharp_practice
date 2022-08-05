/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3* */
using static System.Console;
WriteLine("Введите 2 числа:");
int digit1=int.Parse(ReadLine());
int digit2=int.Parse(ReadLine());
if(digit1>digit2)WriteLine($"max= {digit1}");
else WriteLine($"max= {digit2}");