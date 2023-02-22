using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Complete the function/method so that it takes a PascalCase string and returns 
the string in snake_case notation. Lowercase characters can be numbers. If the 
method gets a number as input, it should return a string.

Examples
"TestController"  -->  "test_controller"
"MoviesAndBooks"  -->  "movies_and_books"
"App7Test"        -->  "app7_test"
1                 -->  "1"
 */

namespace Resh
{
    internal static class Task_3
    {
        public static string ToUnderscore(int str)
        {
            return str.ToString();
        }

        public static string ToUnderscore(string str)
        {
            string str3 = str.ToUpper();
            string str4 = str.ToLower();
            string str2 = "";
            str2 += str4[0];

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str3[i] && !Char.IsDigit(str[i]))
                {
                    str2 += "_" + str4[i];
                }
                else
                {
                    str2 += str[i];
                }
            }
            return str2;
        }

    }
}
