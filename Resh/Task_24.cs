using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*

Count the number of Duplicates
Write a function that will return the count of distinct case-insensitive alphabetic
characters and numeric digits that occur more than once in the input string. The input 
string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.

Example
"abcde" -> 0 # no characters repeats more than once
"aabbcde" -> 2 # 'a' and 'b'
"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
"indivisibility" -> 1 # 'i' occurs six times
"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
"aA11" -> 2 # 'a' and '1'
"ABBA" -> 2 # 'A' and 'B' each occur twice

*/


internal class Task_24
{
    public static int DuplicateCount(string str)
    {
        var list = new List<char>();
        var list2 = new List<char>();
        int count = 0;
        foreach (char i in str.ToLower())
        {
            list.Add(i);
        }

        for (int i = 0; i < list.Count; i++)
        {
            if (CheckTwo(list, list2, i))
            {
                count++;
                list2.Add(list[i]);
            }
        }

        return count;
    }

    private static bool CheckTwo(List<char> list, List<char> list2, int ind)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (i == ind) continue;
            if (list[i] == list[ind])
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list[i] == list2[j]) return false;
                }
                return true;
            }
        }
        return false;
    }
}

