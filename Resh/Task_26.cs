using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Write a function

TripleDouble(long num1, long num2)
which takes numbers num1 and num2 and returns 1 if there is a straight 
triple of a number at any place in num1 and also a straight double of the same number in num2.

If this isn't the case, return 0

Examples
TripleDouble(451999277, 41177722899) == 1 // num1 has straight triple 999s and 
                                          // num2 has straight double 99s

TripleDouble(1222345, 12345) == 0 // num1 has straight triple 2s but num2 has only a single 2

TripleDouble(12345, 12345) == 0

TripleDouble(666789, 12345667) == 1
*/

internal class Task_26
{
    public static int TripleDouble(long num1, long num2)
    {
        string s1 = num1.ToString();
        string s2 = num2.ToString();

        for (int i = 0; i < s1.Length - 3; i++)
        {
            if (s1[i + 1] == s1[i] && s1[i + 2] == s1[i])
            {
                for (int j = 0; j < s2.Length - 1; j++)
                {
                    if (s2[j] == s1[i] && s2[j + 1] == s1[i])
                    {
                        return 1;
                    }
                }
            }
        }
        return 0;
    }
}

