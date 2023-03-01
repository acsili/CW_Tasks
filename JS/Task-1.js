/*
Write an algorithm that takes an array and moves all of the 
zeros to the end, preserving the order of the other elements.

moveZeros([false,1,0,1,2,0,1,3,"a"])
 // returns[false,1,1,2,1,3,"a",0,0]
*/

function moveZeros(arr) 
{
    let a = [];
    let zeros = 0;
    for (let i = 0; i < arr.length; i++)
    {
        if (arr[i] === 0)
        {
            zeros++;
        }
        if (arr[i] !== 0)
        {
            a.push(arr[i]);
        }
    }
    for (let i = 0; i < zeros; i++)
    {
        
        a.push(0);
        
    }
    return a;
}

console.log(moveZeros([2, 4, false, 0, '235', 0, 33, 456, true]));