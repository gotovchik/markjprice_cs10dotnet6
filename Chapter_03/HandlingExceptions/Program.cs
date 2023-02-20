using System;

#region // Перехват исключений

Console.WriteLine("Before parsing");
Console.Write("What is your age? ");
string? input = Console.ReadLine();

try
{
    int age = int.Parse(input);
    Console.WriteLine($"You are {age} years old.");
}
catch (OverflowException)
{
    Console.WriteLine("Your age is a valid number format but is either too big or small");
    
}
catch (FormatException)
{
    Console.WriteLine("The age you entered is not a valid number format.");
    
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType()} says {ex.Message}");
}
Console.WriteLine("After parsing");

#endregion

#region // перехват с помощью фильтров

Console.Write("Enter an amount: ");
string? amount = Console.ReadLine();
try
{
    decimal amountValue = decimal.Parse(amount);
}
catch(FormatException) when (amount.Contains("$"))
{
    Console.WriteLine($"Amount cannot use the dollar sign!");
}
catch (FormatException)
{
    Console.WriteLine("Amounts must only contain digits!"); 
}

#endregion