using System;

int max = 500;
try
{
    checked
    {
        for (byte i = 0; i < max; i++)
        {
            Console.WriteLine(i);
        }
    }
}
catch (OverflowException)
{
    Console.WriteLine($"Переменная переполнилась и функция вызвала исключение переполнения");
}

