using System;

#region // таблица умножения

void TimesTable(byte number)
{
    Console.WriteLine($"This is th {number} times table:");

    for (int row = 0; row < 10; row++)
    {   
        Console.WriteLine($"{row} x {number} = {row * number}");
    }
    Console.WriteLine();
}

// TimesTable(6);

#endregion

#region // вычесление налога

decimal CalculateTax(decimal amount, string twoLetterRegionCode) 
{
    decimal rate = 0.0M;

    switch (twoLetterRegionCode)
    {
        case "CH": // Швейцария
            rate = 0.08M;
            break;
        case "DK": // Дания
        case "NO": // Норвегия
            rate = 0.25M;
            break;
        case "GB": // Великобритания
        case "FR": // Франция
            rate = 0.2M;
            break;
        case "HU": // Венгрия
            rate = 0.27M;
            break;
        case "OR": // Орегон
        case "AK": // Аляска
        case "MT": // Монтана
            rate = 0.0M;
            break;
        case "ND": // Северная Дакота
        case "WI": // Висконсин
        case "ME": // Мэн
        case "VA": // Вирджиния
            rate = 0.05M;
            break;
        case "CA": // Калифорния
            rate = 0.0825M;
            break;
        default:   // большинство штатов США
            rate = 0.06M;
            break;
    }
    
    return amount * rate;
}

// decimal taxToPay = CalculateTax(149000, "FR");
// Console.WriteLine($"You must pay {taxToPay:C} in tax");

#endregion

#region // Кардинальное к порядковому

string CardinalToOrdinal(int number)
{
    int lastTwoDigit = number % 100;
    switch (lastTwoDigit)
    {
        case 11:
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lastDigit = number % 10;

            string suffix = lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
            return $"{number}{suffix}";
    }
}

void RunCardinalToOrdinal()
{
    for (int i = 1; i <= 50; i++)
    {
        Console.Write($"{CardinalToOrdinal(i)} ");
    }
    Console.WriteLine();
}

// RunCardinalToOrdinal();

#endregion

#region // Факториал рекурсией

/// <summary>
/// Передайте 32-битное целое число, функция вернет его факториал
/// </summary>
/// <param name="number">32-битное целое число</param>
/// <returns>Факториал числа</returns>
int Factorial(int number)
{
    if (number < 1)
    {
        return 0;
    }
    else if (number == 1)
    {
        return 1;
    }
    else
    {
        checked
        {
            return number * Factorial(number - 1);
        } 
    }
}

void RunFactorial() 
{
    for (var i = 1; i < 15; i++)
    {
        try
        {
            Console.WriteLine($"{i}! = {Factorial(i):N0}");
        }
        catch (OverflowException)
        {
            Console.WriteLine($"{i}! слишком большое и не может храниться в Int32");
        }
        
    }
}

// RunFactorial();

#endregion

#region // лямбда-выражения

int FibImperative(int term)
{
    if (term == 1)
    {
        return 0;
    }
    else if (term == 2)
    {
        return 1;
    }
    else
    {
        return FibImperative(term - 1) + FibImperative(term - 2);
    }
}

void RunFibImperative()
{
    for (int i = 1; i <= 30; i++)
    {
        Console.WriteLine("The {0} term of the Fibonacci squence is {1:N0}.",
            arg0: CardinalToOrdinal(i),
            arg1: FibImperative(term: i));   
    }
}

// RunFibImperative();

int FibFunctional(int term) =>
    term switch
    {
        1 => 0,
        2 => 1,
        _ => FibFunctional(term - 1) + FibFunctional(term - 2)
    };

void RunFibFunctional()
{
    for (int i = 1; i <= 30; i++)
    {
        Console.WriteLine("The {0} term of the Fibonacci squence is {1:N0}.",
            arg0: CardinalToOrdinal(i),
            arg1: FibFunctional(term: i));   
    }
}

// RunFibFunctional();

#endregion
