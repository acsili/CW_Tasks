using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a function that takes in a string of one or more words, 
and returns the same string, but with all five or more letter 
words reversed (Just like the name of this Kata). Strings passed 
in will consist of only letters and spaces. Spaces will be 
included only when more than one word is present.

Examples:

spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
spinWords( "This is a test") => returns "This is a test" 
spinWords( "This is another test" )=> returns "This is rehtona test"
*/
internal static class Task_15
{
    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    public static string SpinWords(string sentence)
    {
        string[] arr = sentence.Split(' ');
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length >= 5)
            {
                arr[i] = Reverse(arr[i]);
            }
        }
        return string.Join(" ", arr);
    }
}

