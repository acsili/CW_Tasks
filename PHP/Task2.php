<?php
/*
Write simple .camelCase method (camel_case function in PHP, CamelCase in C# or camelCase in Java) 
for strings. All words must have their first letter capitalized without spaces.

For instance:

camel_case("hello case"); // => "HelloCase"
camel_case("camel case word"); // => "CamelCaseWord"
*/
function camel_case(string $s) : string
{
    if ($s == "") return "";
    $str = "";
    foreach (explode(" ", trim($s)) as $str2)
    {
        $str .= strtoupper($str2[0]);
        for ($i = 1; $i < strlen($str2); $i++)
        {
            $str .= $str2[$i];
        }
    }

    return $str;
}

print_r(camel_case("  rege bbfd ae  "));