<?php

/*
This time no story, no theory. The examples below show you how to write function accum:

Examples:
accum("abcd") -> "A-Bb-Ccc-Dddd"
accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
accum("cwAt") -> "C-Ww-Aaa-Tttt"
The parameter of accum is a string which includes only letters from a..z and A..Z.
*/
function accum($s) 
{
    $arr = [];
    for ($i = 0; $i < strlen($s); $i++)
    {
        $str = "";
        $str .= strtoupper($s[$i]);
        for ($j = 0; $j < $i; $j++)
        {
            $str .= strtolower($s[$i]);
        }
        $arr[$i] = $str;
    }
    
   return join("-",$arr);
}

echo accum("wqfsd"); 