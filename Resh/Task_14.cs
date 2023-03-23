using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a function which makes a list of strings representing 
all of the ways you can balance n pairs of parentheses

Examples
balancedParens(0) => [""]
balancedParens(1) => ["()"]
balancedParens(2) => ["()()","(())"]
balancedParens(3) => ["()()()","(())()","()(())","(()())","((()))"]
 */
internal class Task_14
{
    public static List<string> BalancedParens(int n)
    {
        List<string> result = new List<string>();
        balancedParens("", n, 0, 0, result);
        return result;
    }

    private static void balancedParens(String str, int n, int numOpens, int numCloses, List<string> list)
    {
        if (numCloses == n)
        {
            list.Add(str);
            return;
        }
        if (numOpens < n)
        {
            balancedParens(str + "(", n, numOpens + 1, numCloses, list);
        }
        if (numOpens > 0 && numCloses < numOpens)
        {
            balancedParens(str + ")", n, numOpens, numCloses + 1, list);
        }
    }
}

