using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Usually when you buy something, you're asked whether your credit card number, 
phone number or answer to your most secret question is still correct. However, 
since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.

Your task is to write a function maskify, which changes all but the last four 
characters into '#'.

Examples
"4556364607935616" --> "############5616"
     "64607935616" -->      "#######5616"
               "1" -->                "1"
                "" -->                 ""

// "What was the name of your first pet?"

"Skippy" --> "##ippy"

"Nananananananananananananananana Batman!"
-->
"####################################man!"
*/
internal class Task_12
{
    public static string Maskify(string cc)
    {
        string s = "";
        for (int i = 0; i < cc.Length; i++)
        {
            if (i >= cc.Length - 4)
                s += cc[i];
            else s += '#';
        }
        return s;
    }
}

