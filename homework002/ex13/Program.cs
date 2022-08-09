//Задача 13:Напишите программу, которая выводит третью (заданную) цыфру заданного числа или сообщают, что третьей цыфры нет.
using static System.Console;
int digitCount(int digit)//подсчет кол-ва цыфр
{
    int counter = 0;
    while (digit != 0)
    {
        digit /= 10;
        counter++;
    }
    return counter;
}

WriteLine("Ввеждите целое число");
int digit = int.Parse(Console.ReadLine());
WriteLine("Какую цифру этого числа вывести?");
int number = int.Parse(Console.ReadLine());


if (digitCount(digit) <= -number || digitCount(digit) >= number)//когда number число есть
{
    for (int i = 0; i < digitCount(digit); i++)
    {
        digit = (int)(digit / Math.Pow(10, (digitCount(digit) - number)));
        digit %= 10;
    }
    Console.WriteLine($"{number} цыфра равна {digit}");
}
else Console.WriteLine($"{number} цыфры нет в числе {digit}");