using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Extension GroupWhile consecutive by the condition items
 
 In this kata you have to implement an extension method for Enumerable collections: 
GroupWhile(this IEnumerable<object> coll, Func<object, bool> pred) (signature for C#).

The method takes in one argument, pred, of the type Func<object, bool> which checks each 
element of a collection on the satisfaction of a certain condition. The by the order 
consecutive elements should be grouped while this condition is true (s. example and example tests).

#Example

pred: IsLetter
coll: [ 'L', 'e', 't', 't', 'e', 'r', '1', '2', '4', '=', 'a', 'B', 'E', 'l', 'T', '%' ]

result: [ [ 'L', 'e', 't', 't', 'e', 'r' ], [ '1' ], [ '2' ], [ '4' ], [ '=' ], [ 'a', 'B', 'E', 'l', 'T' ], [ '%' ] ];
 
*/

internal static class Task_28
{
    public static IEnumerable<IEnumerable<object>> GroupWhile(this IEnumerable<object> coll, Func<object, bool> pred)
    {
        List<List<object>> res = new List<List<object>>();
        List<object> list = new List<object>();
        foreach (object item in coll)
        {
            if (pred(item))
            {
                list.Add(item);
            }
            else
            {
                if (list.Any())
                {
                    res.Add(list);
                }
                list = new List<object> { item };
                res.Add(list);
                list = new List<object>();
            }

        }
        if (list.Any())
        {
            res.Add(list);
        }

        return res;
    }
}

