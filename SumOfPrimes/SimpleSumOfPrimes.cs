using System;
using System.Collections.Generic;

namespace SumOfPrimes
{
    public class SimpleSumOfPrimes : ISumOfPrimes
    {
        #region ISumOfPrimes Members

        public List<int> FindPrimes(int n)
        {
            var primes = new List<int>();

            int i = 2;

            primes.Add(1);

            //test i for primality until list of primes is size desired
            while (primes.Count <= n)
            {
                bool prime = true;

                for (int j = 1; j < Math.Sqrt(i); j++)
                {
                    if (j%i == 0)
                    {
                        prime = false;
                    }
                }

                if (prime)
                {
                    primes.Add(i);
                }

                i++;
            }

            return primes;
        }

        public long SumOfPrimes(List<int> primes)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}