namespace PrimeFactorsLib
{
    public class PrimeFactors
    {
        public List<int> GetPrimes(int number)
        {
            List<int> primes = new List<int>();
            
            for(int div = 2; div <= number; div++) 
                while (number % div == 0)
                {
                    primes.Add(div);
                    number /= div;
                }
            return primes;
        }
    }
}