function solution(number)
{
    let romanNumbers = ("M", "CMXC", "CM", "D", "CDXC", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I")
    let arab = (1000, 990, 900, 500, 490, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1)
    let result = ""
    let i = 0
    while (number > 0 || arab.length == (i - 1)) 
    {
        while ((number - arab[i]) >= 0) 
        {
            number -= arab[i]
            result += romanNumbers[i]
        }
        i++
    }
    return result
}

console.log(solution(111))