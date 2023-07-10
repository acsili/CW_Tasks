using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 A format for expressing an ordered list of integers is to use a comma separated list of either

individual integers
or a range of integers denoted by the starting integer separated from the end integer in the range 
by a dash, '-'. The range includes all integers in the interval including both endpoints. 
It is not considered a range unless it spans at least 3 numbers. For example "12,13,15-17"
Complete the solution so that it takes a list of integers in increasing order and returns a correctly formatted string in the range format.

Example:

solution([-10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]);
// returns "-10--8,-6,-3-1,3-5,7-11,14,15,17-20"
*/

internal class Task_25
{
    public static string Extract(int[] args)
    {
        List<string> list = new List<string>();
        List<string> listRes = new List<string>();

        list.Add(args[0].ToString());

        for (int i = 1; i < args.Length; i++)
        {
            if (args[i - 1] + 1 == args[i])
            {
                list.Add(args[i].ToString());
            }
            else
            {
                if (list.Count < 3)
                {
                    for (int j = 0; j < list.Count; j++) listRes.Add(list[j]);
                    list.Clear();
                    list.Add(args[i].ToString());
                }
                else
                {
                    listRes.Add(list[0] + "-" + list[list.Count - 1]);
                    list.Clear();
                    list.Add(args[i].ToString());
                }
            }
        }

        if (list.Count < 3) for (int j = 0; j < list.Count; j++) listRes.Add(list[j]);
        else listRes.Add(list[0] + "-" + list[list.Count - 1]);

        return string.Join(",", listRes);
    }
}

