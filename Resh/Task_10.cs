using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 In this Kata, you will be given a string that may have mixed uppercase 
and lowercase letters and your task is to convert that string to either lowercase only 
or uppercase only based on:

make as few changes as possible.
if the string contains equal number of uppercase and lowercase letters, convert 
the string to lowercase.
For example:

solve("coDe") = "code". Lowercase characters > uppercase. Change only the "D" to lowercase.
solve("CODe") = "CODE". Uppercase characters > lowecase. Change only the "e" to uppercase.
solve("coDE") = "code". Upper == lowercase. Change all to lowercase.
*/
internal static class Task_10
{
    public static string Solve(string s)
    {
        int lowercase = s.Where(x => Char.IsLower(x)).Count();
        int uppercase = s.Where(x => Char.IsUpper(x)).Count();

        if (lowercase > uppercase)
        {
            return s.ToLower();
        }
        else if (lowercase < uppercase)
        {
            return s.ToUpper();
        }
        else
        {
            return s.ToLower();
        }

    }
}

