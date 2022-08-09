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
int reduce (int digit, int number)
{if (digitCount(digit) - number == 0)
        return digit%10;
else
    return reduce(digit / 10,number);
}
WriteLine("Ввеждите целое число");
int digit = int.Parse(ReadLine());
WriteLine("Какую цифру этого числа вывести?");
int number = int.Parse(ReadLine());


if (digitCount(digit) <= -number || digitCount(digit) >= number)//когда number число есть
{
    for (int i = 0; i < digitCount(digit); i++)
    {
        digit = reduce(digit,number);
    }
    WriteLine($"{number} цыфра равна {digit}");
}
else WriteLine($"{number} цыфры нет в числе {digit}");