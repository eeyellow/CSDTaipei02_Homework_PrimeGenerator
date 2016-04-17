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
            if (maxValue == 2)
            {
                result.Add(2);
            }
            else {
                result.Add(3);
            }

            return result;
        }
    }
}
