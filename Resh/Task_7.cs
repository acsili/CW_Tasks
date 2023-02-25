using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Complete the solution so that it returns true if the first argument(string) 
    passed in ends with the 2nd argument (also a string).

    Examples:

    solution('abc', 'bc') // returns true
    solution('abc', 'd') // returns false
*/
internal static class Task_7
{
    public static bool Solution(string str, string ending)
    {
        if (ending.Length > str.Length) { return false; }

        int n = 0;
        
        for (int i = str.Length - ending.Length; i < str.Length; i++)
        {
            if (str[i] == ending[i - (str.Length - ending.Length)])
            {
                n++;
            }
        }

        if (n == ending.Length) { return true; } else { return false; }

    }
}

