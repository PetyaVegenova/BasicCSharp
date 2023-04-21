namespace _03.WhatIsThe47_thPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = false;
            int primeIndex = 0;
            int primeValue = 1;

            while (primeIndex < 47)
            {
                primeValue++;

                isPrime = IsPrime(primeValue);

                if (isPrime)
                {
                    primeIndex++;
                }
            }

            Console.WriteLine($"The 47-th prime number is {primeValue}");
        }

        private static bool IsPrime(int primeValue)
        {
            var result = true;

            for (int i = 2; i <= Math.Sqrt(primeValue); i++)
            {
                if (primeValue % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}