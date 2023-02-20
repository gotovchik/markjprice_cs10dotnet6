using System;

for(int i = 1; i <= 100; i++)
{
    if(i % 3 == 0) Console.Write($"fizz ");
    else if(i % 5 == 0) Console.Write($"buzz ");
    else if(i % 3 == 0 && i % 5 == 0) Console.Write("fizzbuzz ");
    else Console.Write($"{i} ");
}