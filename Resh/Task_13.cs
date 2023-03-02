using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
*/

internal static class Task_13
{
    public static string DuplicateEncode(string word)
    {
        string chars = word.ToLower();
        string s = "";
        int p = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            for (int j = 0; j < chars.Length; j++)
            {
                if (chars[i] == chars[j])
                {
                    p += 1;
                }

            }
            if (p > 1)
            {
                s += ')';
            }
            else
            {
                s += '(';
            }
            p = 0;
        }
        return s;
    }
}

