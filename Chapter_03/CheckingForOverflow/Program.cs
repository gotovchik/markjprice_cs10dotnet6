using System;

try
{
    checked
    {
        int x = int.MaxValue - 1;
        Console.WriteLine($"Initinal value: {x}");
        x++;
        Console.WriteLine($"After incrementing: {x}");
        x++;
        Console.WriteLine($"After incrementing: {x}");
        x++;
        Console.WriteLine($"After incrementing: {x}");
    }
}
catch (OverflowException)
{
    Console.WriteLine("The code overflowed but I caught the exception");
}

unchecked
{
    int y = int.MaxValue + 1;
    Console.WriteLine($"Initial value: {y}");
    y--;
    Console.WriteLine($"After decrementing: {y}");
    y--;
    Console.WriteLine($"After decrementing: {y}");
}    
    
    
