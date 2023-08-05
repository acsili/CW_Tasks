/*
You need to swap the head and the tail of the specified array:

the head (the first half) of array moves to the end, the tail (the second half) 
moves to the start. The middle element (if it exists) leaves on the same position.

Return new array.

For example:

   [ 1, 2, 3, 4, 5 ]   =>  [ 4, 5, 3, 1, 2 ]
    \----/   \----/         
     head     tail 

   [ -1, 2 ]  => [ 2, -1 ] 
   [ 1, 2, -3, 4, 5, 6, -7, 8 ]   =>  [ 5, 6, -7, 8, 1, 2, -3, 4 ]  

*/




function swapHeadAndTail(arr) 
{
    let res = [];
    if (arr.length % 2 != 0) res.push(arr[Math.floor(arr.length / 2)]);
    for (let i = 0, j = arr.length - 1; i < arr.length; i++)
    {
        if (arr.length % 2 != 0 && i === Math.floor(arr.length / 2)) continue;
        if (i < arr.length / 2) res.push(arr[i]);
        else 
        {
            res.unshift(arr[j]);
            j--;
        }
    }
    return res;
}

console.log(swapHeadAndTail([1, 2, 3, 4, 5, 6]))