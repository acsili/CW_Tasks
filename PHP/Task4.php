<?php

/*
You are given a list of numbers (positive / negative integers) 
and you need to get the nearest entries of a given value.

For example:

The number 10 is given and you need to get the nearest number 
in this series: 1, 2, 3, 4, 6, 12. The answer should be 12.

$intArray   = [1,2,3,4,6,12];
$givenValue = 10;

roundUp($givenValue, $intArray) => [12];

If the given number is 5, the result should be {4,6};

$intArray   = [1,2,3,4,6,12];
$givenValue = 5;

roundUp($givenValue, $intArray) => [4, 6];
*/

function roundUp(int $number, array $list)
{
    $arr = [];
    $min = PHP_INT_MAX;
    
    for ($i = 0; $i < count($list); $i++)
    {
        if (abs($number - $list[$i]) <= $min)
        {
            $min = abs($number - $list[$i]);
        }
    }
    
    for ($i = 0; $i < count($list); $i++)
    {
        if (abs($number - $list[$i]) == $min)
        {
            array_push($arr, $list[$i]);
        }
    }
    
    return $arr;
}

print_r(roundUp(5, [1,2,3,4,6,12]));