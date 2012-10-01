using System.Linq;

namespace SelfDescribingNumbers
{
    public class SimpleSelfDescribingNumberfinder : ISelfDescribingFinder
    {
        #region ISelfDescribingFinder Members

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

        #endregion

        private static int charCountInString(char character, string str)
        {
            return str.Count(t => t == character);
        }
    }
}