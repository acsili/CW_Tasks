function getSum(a, b)
{
    let s = 0
    for (let i = a; i <= b; i++)
    {
       s += i
    }
    return s
}

console.log(getSum(1, 2))