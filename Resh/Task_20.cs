using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a function, which takes a non-negative integer (seconds) as input 
and returns the time in a human-readable format (HH:MM:SS)

HH = hours, padded to 2 digits, range: 00 - 99
MM = minutes, padded to 2 digits, range: 00 - 59
SS = seconds, padded to 2 digits, range: 00 - 59
The maximum time never exceeds 359999 (99:59:59)

You can find some examples in the test fixtures.
*/

internal class Task_20
{
    public static string GetReadableTime(int mySeconds)
    {
        int myHours = mySeconds / 3600; 
        mySeconds %= 3600;

        int myMinutes = mySeconds / 60;
        mySeconds %= 60;

        string mySec = mySeconds.ToString(),
        myMin = myMinutes.ToString(),
        myHou = myHours.ToString();

        if (myHours < 10) { myHou = myHou.Insert(0, "0"); }

        if (myMinutes < 10) { myMin = myMin.Insert(0, "0"); }

        if (mySeconds < 10) { mySec = mySec.Insert(0, "0"); }

        return myHou + ":" + myMin + ":" + mySec;
    }

}

