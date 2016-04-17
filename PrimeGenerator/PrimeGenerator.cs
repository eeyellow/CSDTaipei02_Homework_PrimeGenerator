using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIVALACODE
{
    public static class PrimeGenerator
    {
        public static List<int> result = new List<int>();
        public static int[] GeneratePrimes(int maxValue)
        {
            for (int i = maxValue; i >= 2; i--) {
                List<int> primeList = PrimeFactor.breakdown(i);
                for (int j = 0; j < primeList.Count; j++)
                {
                    if (!result.Contains(primeList[j]))
                    {
                        result.Add(primeList[j]);
                    }
                }
            }
            result.Sort();
            return result.ToArray();
        }
    }
}
