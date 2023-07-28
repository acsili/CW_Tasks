/*
Find the integer from a to b (included) with the greatest number of divisors. For example:

divNum(15, 30)   ==> 24
divNum(1, 2)     ==> 2
divNum(0, 0)     ==> 0
divNum(52, 156)  ==> 120
If there are several numbers that have the same (maximum) number of divisors, the smallest 
among them should be returned. Return the string "Error" if a > b.

*/

const divNum = (a, b) => 
{
    if (a > b) return 'Error';
    
    let c;
    let cMax = 0;
    let max = 0;
    for (let i = a; i <= b; i++)
    {
        c = 0;
        for (let j = 1; j <= i; j++)
        {
            if (i % j == 0) c++;
        }
        if (c > cMax)
        {
            max = i;
            cMax = c;
        }
    }
    return max;
};


console.log(divNum(15, 30));