using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Substitute two equal letters by the next letter of the alphabet (two letters convert to one):

"aa" => "b", "bb" => "c", .. "zz" => "a".
The equal letters do not have to be adjacent.
Repeat this operation until there are no possible substitutions left.
Return a string.

Example:

let str = "zzzab"
    str = "azab"
    str = "bzb"
    str = "cz"
return "cz"
Notes
The order of letters in the result is not important.
The letters "zz" transform into "a".
There will only be lowercase letters.
*/

internal class Task_23
{
    public static bool CheckTwo(string str, ref (int, int) ind)
    {
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < str.Length; j++)
            {
                if (i == j) continue;
                if (str[i] == str[j])
                {
                    ind.Item1 = i;
                    ind.Item2 = j;
                    return true;
                }
            }
        }
        return false;
    }

    public static string last_survivors(string str)
    {
        StringBuilder stringBuilder = new StringBuilder(str);
        (int, int) ind = (1, 1);

        while (CheckTwo(stringBuilder.ToString(), ref ind))
        {
            char letter = stringBuilder[ind.Item1];
            stringBuilder.Remove(ind.Item1, 1);
            stringBuilder.Remove(ind.Item2 - 1, 1);
            if (letter == 'z') stringBuilder.Append('a');
            else stringBuilder.Append((char)(letter + 1));
        }

        return stringBuilder.ToString();
    }
}

