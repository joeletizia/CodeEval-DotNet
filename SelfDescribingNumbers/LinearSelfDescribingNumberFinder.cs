using System;

namespace SelfDescribingNumbers
{
    public class LinearSelfDescribingNumberFinder : ISelfDescribingFinder
    {
        #region ISelfDescribingFinder Members

        public bool Test(ulong n)
        {
            bool ret = true;
            string nStr = n.ToString();
            var result = new int[nStr.Length];

            //loop through the nStr while incremementing the value at the current index in result.
            for (int i = 0; i < nStr.Length; i++)
            {
                result[Int32.Parse(nStr[i].ToString())]++;
            }

            //compare each element in the nStr to the element in result. If different, it is not a self describing number.
            for (int i = 0; i < nStr.Length; i++)
            {
                if (result[i] + 48 != nStr[i])
                {
                    ret = false;
                    break;
                }
            }

            return ret;
        }

        #endregion
    }
}