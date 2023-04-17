using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
 The goal of this exercise is to convert a string to a new string 
where each character in the new string is "(" if that character appears 
only once in the original string, or ")" if that character appears more 
than once in the original string. Ignore capitalization when determining 
if a character is a duplicate.

Examples
"din"      =>  "((("
"recede"   =>  "()()()"
"Success"  =>  ")())())"
"(( @"     =>  "))((" 
*/

public class Task_13
{
    public string DuplicateEncode(string word)
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

