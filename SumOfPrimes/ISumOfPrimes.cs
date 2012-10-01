using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPrimes
{
    public interface ISumOfPrimes
    {
        List<int> FindPrimes(int n);
        long SumOfPrimes(List<int> primes);
    }
}
