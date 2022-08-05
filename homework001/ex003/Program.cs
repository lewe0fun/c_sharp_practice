/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */
using static System.Console;
    WriteLine("Введите целое число: ");
    int digit=int.Parse(ReadLine());
if(Convert.ToBoolean(digit%2))WriteLine("НЕТ");
else WriteLine("ДА");


