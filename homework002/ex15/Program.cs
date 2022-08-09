//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является лиэтот день выходным.
using static System.Console;
bool isHoliday(int day) { return day>5 ? true : false; }
int day;
do
{
    Write("Введите цифру, обозначающую день недели: ");
    day = int.Parse(Console.ReadLine());
} while (day > 7||day<1);

Write($"Этот день выходной? ");
if (isHoliday(day)) Write("Да.");
else Write("Нет.");