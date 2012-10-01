using System.Collections.Generic;

namespace SumOfPrimes
{
    public interface ISumOfPrimes
    {
        List<int> FindPrimes(int n);
        long SumOfPrimes(List<int> primes);
    }
}