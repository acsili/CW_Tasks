/*

The main idea is to count all the occurring characters in a string. If you have 
a string like aba, then the result should be {'a': 2, 'b': 1}.

What if the string is empty? Then the result should be empty object literal, {}.


*/


function count(string) 
{
    if (string == '') return {};
    let count = 0;
    var res = new Map();

    for (let i = 0; i < string.length; i++)
    {
        for (let j = 0; j < string.length; j++)
        {
            if (string[i] == string[j])
            {
                count++;
            }
        }
        res.set(string[i], count);
        count = 0;
    }
    return Object.fromEntries(res);
}


let user = count('asqwwa');
console.log(user); 