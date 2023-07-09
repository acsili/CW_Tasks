function sumDigits(number) 
{
    let sNum = Math.abs(number).toString().split('');
    let sum = Math.abs(number).toString().split('').reduce((partialSum, a) => partialSum + Number(a), 0);
    return Math.abs(number).toString().split('').reduce((partialSum, a) => partialSum + Number(a), 0);
} 

let s = 123;
console.log(sumDigits(s));