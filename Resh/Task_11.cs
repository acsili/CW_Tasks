using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a function that takes an integer as input, and returns the number 
of bits that are equal to one in the binary representation of that number. 
You can guarantee that input is non-negative.

Example: The binary representation of 1234 is 10011010010, so the function 
should return 5 in this case
*/
internal static class Task_11
{
    public static int CountBits(int n)
    {
        string bit = Convert.ToString(n, 2);
        int c = 0;
        for (int i = 0; i < bit.Length; i++)
        {
            if (bit[i] == '1')
            {
                c++;
            }
        }
        return c;
    }
}
