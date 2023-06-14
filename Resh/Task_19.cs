using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Task_19
{
    public static long longPow(long x, long pow)
    {
        long ret = 1;
        while (pow != 0)
        {
            if ((pow & 1) == 1)
                ret *= x;
            x *= x;
            pow >>= 1;
        }
        return ret;
    }
    public static long[] SumDigPow(long a, long b)
    {
        List<long> result = new List<long>();
        for (long i = a; i <= b; i++)
        {
            string s = i.ToString();
            long sum = 0;
            for (int j = 0; j < s.Length; j++)
            {
                sum += longPow(long.Parse(s[j].ToString()), j + 1);
            }
            if (sum == i) result.Add(i);
        }

        return result.ToArray();
    }

}

