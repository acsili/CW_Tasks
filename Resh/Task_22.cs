using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

/*
Write a function, persistence, that takes in a positive parameter num and returns its 
multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.

For example (Input --> Output):

39 --> 3 (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit)
999 --> 4 (because 9*9*9 = 729, 7*2*9 = 126, 1*2*6 = 12, and finally 1*2 = 2)
4 --> 0 (because 4 is already a one-digit number)
*/
public class Task_22
{
    public static int Persistence(long n)
    {
        if (n < 10) return 0;
        string nStr = n.ToString();
        int cou = 0;
        while (nStr.Length > 1)
        {
            int num = 1;
            cou++;
            for (int i = 0; i < nStr.Length; i++)
            {
                num *= int.Parse(nStr[i].ToString());
            }
            nStr = num.ToString();
        }
        return cou;
    }
}
