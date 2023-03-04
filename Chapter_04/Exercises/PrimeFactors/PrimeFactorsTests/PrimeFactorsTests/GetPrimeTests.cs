using PrimeFactorsLib;

namespace PrimeFactorsTests
{
    public class GetPrimeTests
    {
        [Fact]
        public void TestGetPrimeFactors9()
        {
            int number = 9;
            List<int> expected = new() { 3, 3 };
            PrimeFactors primeFactors = new();

            List<int> actual = primeFactors.GetPrimes(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetPrimeFactors874()
        {
            int number = 874;
            List<int> expected = new() { 2, 19, 23 };
            PrimeFactors primeFactors = new();

            List<int> actual = primeFactors.GetPrimes(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetPrimeFactors123()
        {
            int number = 123;
            List<int> expected = new() { 3, 41 };
            PrimeFactors primeFactors = new();

            List<int> actual = primeFactors.GetPrimes(number);

            Assert.Equal(expected, actual);
        }
    }
}