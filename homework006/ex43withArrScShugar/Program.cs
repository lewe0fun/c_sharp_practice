//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

using static System.Console;

WriteLine("Введите черкз пробел 4 координаты: b1, k1, b2, k2");
double[] points = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToArray();

printResult(points);

void printResult(double[]arr)
{
    if (arr[1] == arr[3])
    {
        if (arr[0] == arr[2]) WriteLine("Прямые совпадают");
        else WriteLine("Прямые параллельны");
    }
    else WriteLine($"Точка пересечения прямых: ({x(arr)};{y(arr)})");
}
double x(double[]arr)
{
    return (arr[2] - arr[0]) / (arr[1] - arr[3]);
}
double y(double[]arr)
{
    return arr[1] * x(arr) + arr[0];
}