using static System.Console;
using PrimeFactorsLib;

public class Program
{
    public static void Main(string[] args)
    {
        WriteLine("Введите число:");
        List<int> list = new();
        PrimeFactors primeFactors = new();
        if (int.TryParse(ReadLine(), out int number))
        {
            list = primeFactors.GetPrimes(number);
        };
        foreach (var item in list)
        {
            WriteLine($"{item} ");
        }
        ReadKey();

    }
}

