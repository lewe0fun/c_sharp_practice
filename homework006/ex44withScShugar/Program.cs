
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2-> 2

//1, -7, 567, 89, 223-> 3

using static System.Console;

WriteLine("Введите числа через запятую:");
int count = ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray().ToArray().Where(a => a >0).Count();
Write($"->{ count}");

