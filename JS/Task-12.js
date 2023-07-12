/*
Implement a function, so it will produce a sentence out of the given parts.

Array of parts could contain:

words;
commas in the middle;
multiple periods at the end.
Sentence making rules:

there must always be a space between words;
there must not be a space between a comma and word on the left;
there must always be one and only one period at the end of a sentence.
Example:

makeSentence(['hello', ',', 'my', 'dear']) // returns 'hello, my dear.'

*/



function makeSentence(parts) 
{
    let arr = [];
    for (let i = 0; i < parts.length - 1; i++)
    {
        if (parts[i + 1] == ',')
        {
            arr.push(parts[i] + parts[i + 1]);
            i++;
        }
        else 
        {
            arr.push(parts[i]);
        }
    }
    arr.push(parts[parts.length - 1]);

    while (arr[arr.length - 1] == '.' || arr[arr.length - 1] == ' ')
    {
        arr.pop();
    }

    return arr.join(' ') + '.';
}



console.log(makeSentence(['hello', 'world']));
