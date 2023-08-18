using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Acknowledgments:
I thank yvonne-liu for the idea and for the example tests :)

Description:
Encrypt this!

You want to create secret messages which can be deciphered by the Decipher this! kata. Here are the conditions:

Your message is a string containing space separated words.
You need to encrypt each word in the message using the following rules:
The first letter must be converted to its ASCII code.
The second letter must be switched with the last letter
Keepin' it simple: There are no special characters in the input.
Examples:
encryptThis "Hello" == "72olle"
encryptThis "good" == "103doo"
encryptThis "hello world" == "104olle 119drlo"

*/
internal class Task_29
{
    public static string EncryptThis(string input)
    {
        var res = input.Split(' ').ToList();
        StringBuilder stringBuilder;
        char ch = ' ';
        for (int i = 0; i < res.Count; i++)
        {
            stringBuilder = new StringBuilder();
            if (res[i].Length >= 2) ch = res[i][1];
            for (int j = 0; j < res[i].Length - 1; j++)
            {

                if (j == 0) stringBuilder.Append((int)res[i][j]);
                else if (res[i].Length == 2) stringBuilder.Append(res[i][j]);
                else if (res[i].Length >= 3 && j == 1) stringBuilder.Append(res[i][^1]);
                else stringBuilder.Append(res[i][j]);
            }
            if (res[i].Length == 1) stringBuilder.Append((int)res[i][0]);
            if (res[i].Length >= 2) stringBuilder.Append(ch);
            res[i] = stringBuilder.ToString();
        }
        return string.Join(" ", res);
    }
}

