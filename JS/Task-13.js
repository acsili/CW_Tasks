
function isPrime(num) 
{
    if (num <= 1) return false;
    if( num == 2 || num == 3) return true;
    if (num % 6 != 5 && num % 6 != 1) return false;
    let div = 5;
    while (div <= Math.sqrt(num))
    {
        if (num % (div) == 0 || num % (div + 2) == 0) return false;
        div += 6;
    }
    return true;
}
  

console.log(isPrime(45));