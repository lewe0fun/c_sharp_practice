//Задача 10:
//    Напишите программу, которая принимает на вход трехзначное число и на выходе показывает
//    вторую цифру этого числа.
using static System.Console;
int getDigit()
{
    int digit;
    do
    {
        WriteLine("Введите положительное целое трехзначное число: ");
        digit = int.Parse(Console.ReadLine());
    } while (digit < 100 || digit > 999);
    return digit;
}
void showDigit(int digit)
{
    WriteLine ($"Вторая цифра этого числа: {(digit / 10) % 10}");
}
string choice;
do
{
    showDigit(getDigit());
    WriteLine("Еще число? введите (да), чтобы продолжить");
    choice = Console.ReadLine();
}while (choice =="да");

