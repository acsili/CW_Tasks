using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
My friend John and I are members of the "Fat to Fit Club (FFC)". John is worried 
because each month a list with the weights of members is published and each month he is 
the last on the list which means he is the heaviest.

I am the one who establishes the list so I told him: "Don't worry any more, I will modify 
the order of the list". It was decided to attribute a "weight" to numbers. The weight of 
a number will be from now on the sum of its digits.

For example 99 will have "weight" 18, 100 will have "weight" 1 so in the list 100 will 
come before 99.

Given a string with the weights of FFC members in normal order can you give this string 
ordered by "weights" of these numbers?

Example:
"56 65 74 100 99 68 86 180 90" ordered by numbers weights becomes: 

"100 180 90 56 65 74 68 86 99"
When two numbers have the same "weight", let us class them as if they were strings 
(alphabetical ordering) and not numbers:

180 is before 90 since, having the same "weight" (9), it comes before as a string.

All numbers in the list are positive numbers and the list can be empty.

Notes
it may happen that the input string have leading, trailing whitespaces and more than 
a unique whitespace between two consecutive numbers
For C: The result is freed.
*/
internal static class Task_9
{
    public static string orderWeight(string strng)
    {
        string[] weights = strng.Split();
        List<int> weightsList = new List<int>();
        int sum = 0;
        int intWeight = 0;
        foreach (string weight in weights)
        {
            intWeight = Convert.ToInt32(weight);
            for (int i = 0; i < weight.Length; i++)
            {
                sum += intWeight % 10;
                intWeight = intWeight / 10;
            }
            weightsList.Add(sum);
            sum = 0;
            intWeight = 0;
        }

        for (int i = 0; i < weightsList.Count; i++)
        {
            for (int j = 0; j < weightsList.Count - 1; j++)
            {
                if (weightsList[j] > weightsList[j + 1])
                {
                    int t = weightsList[j];
                    weightsList[j] = weightsList[j + 1];
                    weightsList[j + 1] = t;
                    string z = weights[j];
                    weights[j] = weights[j + 1];
                    weights[j + 1] = z;
                }
            }
        }

        return String.Join(" ", weights);
    }

}
