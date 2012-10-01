using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfDescribingNumbers
{
    public class SimpleSelfDescribingNumberfinder : ISelfDescribingFinder
    {
        public bool Test(ulong n)
        {
            string numString = n.ToString();

            for (int i = 0; i < numString.Length; i++)
            {
                int count = charCountInString(i.ToString()[0], numString);
                
                if (count + 48 != numString[i])
                {
                    return false;
                }
            }

            return true;
        }

        private static int charCountInString(char character, string str)
        {
            return str.Count(t => t == character);
        }
    }
}
