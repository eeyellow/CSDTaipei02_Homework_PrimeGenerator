using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIVALACODE
{
    /// <summary>
    /// 質因數分解
    /// </summary>
    public static class PrimeFactor
    {
        public static List<int> breakdown(int num)
        {
            List<int> result = new List<int>();

            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0 && num != 1)
                {
                    result.Add(i);
                    num = num / i;
                }
            }

            return result;
        }
    }
}