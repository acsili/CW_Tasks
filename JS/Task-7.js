function count(string) 
{
    let count = 0;
    var sayings = new Object();

    for (let i = 0; i < string.length; i++)
    {
        for (let j = 0; j < string.length; j++)
        {
            if (string[i] == string[j])
            {
                count++;
            }
        }
        sayings.set(string[i], count);
        count = 0;
    }
    return sayings;
}

let str = 'asdfbdf';

let s = count(str);

for (let s2 of s)
{
    console.log(s2);
}

