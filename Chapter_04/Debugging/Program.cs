using System;

double Add(double x, double y)
{
    return x * y;
}

double a = 4.5;
double b = 2.5;
double answer = Add(a, b);
Console.WriteLine($"{a} + {b} = {answer}");

Console.WriteLine("Нажмите любую кнопку для выхода из приложения");
Console.ReadKey();