/* **Задача 4:** Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
using static System.Console;
WriteLine("Введите 3 числа: ");
int[] digits=new int[3];
digits[0]=int.Parse(ReadLine());
digits[1]=int.Parse(ReadLine());
digits[2]=int.Parse(ReadLine());
int max=digits[0];
for (int i = 0; i < digits.Length; i++)if(max<digits[i])max=digits[i];
WriteLine($"max={max}");