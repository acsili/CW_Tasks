using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Your task is to sort a given string. Each word in the string will contain a single 
number. This number is the position the word should have in the result.

Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

If the input string is empty, return an empty string. The words in the input String 
will only contain valid consecutive numbers.

Examples
"is2 Thi1s T4est 3a"  -->  "Thi1s is2 3a T4est"
"4of Fo1r pe6ople g3ood th5e the2"  -->  "Fo1r the2 g3ood 4of th5e pe6ople"
""  -->  ""
 */


internal static class Task_5
{
    public static string Order(string words)
    {
        string[] arr = words.Split();
        string[] str = new string[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            foreach (char c in arr[i].ToCharArray())
            {
                if (Char.IsDigit(c))
                {
                    str[Convert.ToInt32(Char.GetNumericValue(c)) - 1] = arr[i];
                }
            }
        }
        if (str.Length < 1) return "";

        return String.Join(" ", str);
    }
}

