/*
Write an algorithm that will identify valid IPv4 addresses in dot-decimal 
format. IPs should be considered valid if they consist of four octets, 
with values between 0 and 255, inclusive.

Valid inputs examples:
Examples of valid inputs:
1.2.3.4
123.45.67.89
Invalid input examples:
1.2.3
1.2.3.4.5
123.456.78.90
123.045.067.089
Notes:
Leading zeros (e.g. 01.02.03.04) are considered invalid
Inputs are guaranteed to be a single string
*/

function isNumeric(str) 
{
    if (str.replace(/\D/g,'') == str) return true;
    else return false;

}

function isValidIP(str) 
{
    let arr = str.split('.');
    if (arr.length != 4) return false;
    
    for (let i = 0; i < arr.length; i++)
    {
        if (arr[i].length == '') return false;
        if (arr[i].length > 3) return false;
        if (!isNumeric(arr[i])) return false;
        if (Number(arr[i]) > 255 || Number(arr[i]) < 0) return false;
        if (arr[i].length > 1 && arr[i][0] == '0') return false;
        if (arr[i].length > 1 && arr[i][0] == ' ') return false;
        if (arr[i].length > 1 && arr[i][1] == ' ') return false;
        if (arr[i].length > 1 && arr[i][2] == ' ') return false;
    }
    
    return true;
}
   
console.log(isValidIP("137..156.2"));