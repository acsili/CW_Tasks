using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 I will give you an integer (N) and a string. Break the string up into as many 
substrings of N as you can without spaces. If there are leftover characters, include those as well.

Example: 

n = 5;

str = "This is an example string";

Return value:
Thisi
sanex
ample
strin
g

Return value as a string: "Thisi"+"\n"+"sanex"+"\n"+"ample"+"\n"+"strin"+"\n"+"g"
*/

internal class Task_27
{
    public static string StringBreakers(int n, string str)
    {
        string s = str.Replace(" ", "");
        StringBuilder sb = new StringBuilder();
        List<string> list = new List<string>();
        int c = 0;
        for (int i = 0; i < s.Length; i++)
        {
            sb.Append(s[i]);
            c++;
            if (c == n)
            {
                list.Add(sb.ToString());
                c = 0;
                sb.Clear();
            }
        }

        if (c != 0) list.Add(sb.ToString());

        return string.Join("\n", list);
    }
}

