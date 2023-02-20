using System;

Console.Write("Введите число от 0 до 255: ");
string? firstInput = Console.ReadLine();
Console.Write("Введите второе число от 0 до 255: ");
string? secondInput = Console.ReadLine();
try
{
    byte a = byte.Parse(firstInput);
    byte b = byte.Parse(secondInput);
    int result = (a / b);
    Console.WriteLine($"{a} divided by {b} is {result}");
    
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
}

    
