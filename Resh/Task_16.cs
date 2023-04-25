using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Complete the solution so that it splits the string into pairs of 
two characters. If the string contains an odd number of characters
then it should replace the missing second character of the final pair with an underscore ('_').

Examples:

* 'abc' =>  ['ab', 'c_']
* 'abcdef' => ['ab', 'cd', 'ef']
*/
internal class Task_16
{
    public static string[] Solution(string str)
    {
        List<string> list = new List<string>();
        int i = 0;
        while (i < str.Length)
        {
            try
            {
                if (i % 2 == 0)
                {
                    string s = str[i] + "" + str[i + 1];
                    list.Add(s);
                }
            }
            catch
            {
                string s = str[i] + "_";
                list.Add(s);
            }

            i++;
        }
        return list.ToArray();
    }
}

