using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIVALACODE
{
    public static class PrimeGenerator
    {
        public static List<int> result = new List<int>();
        public static List<int> getPrime(int maxValue)
        {
            List<int> primeList = PrimeFactor.breakdown(maxValue);
            for(int i = 0; i < primeList.Count; i++)
            {
                if (!result.Contains(primeList[i]))
                {
                    result.Add(primeList[i]);
                }
            }

            return result;
        }
    }
}
