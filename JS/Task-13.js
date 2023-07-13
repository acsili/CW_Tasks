function formatDuration(seconds) 
{
    if (seconds === 0) return 'now';
    if (seconds === 1) return seconds + ' second';

    let minuteSec = 60;
    let hourSec = 3600;
    let daySec = 86400;
    let yearSec = 31536000;

    let dateMap = new Map([
        ["years", 0],
        ["days", 0],
        ["hours", 0],
        ["minutes", 0],
        ["seconds", 0]
    ]); 

    let years = Math.floor(seconds / yearSec);
    dateMap.set("years", Math.floor(seconds / yearSec));
    seconds -= years * yearSec;
    
    let days = Math.floor(seconds / daySec);
    dateMap.set("days", Math.floor(seconds / daySec));
    seconds -= days * daySec;
    
    let hours = Math.floor(seconds / hourSec);
    dateMap.set("hours", Math.floor(seconds / hourSec));
    seconds -= hours * hourSec;

    let minutes = Math.floor(seconds / minuteSec);
    dateMap.set("minutes", Math.floor(seconds / minuteSec));
    seconds -= minutes * minuteSec;
    
    dateMap.set("seconds", seconds);

    let a = [];
    
    for (let entry of dateMap) 
    { 
        if (entry[1] === 0) continue;
        else
        {
            if (entry[1] === 1)
            {
                a.push(entry[1] + ' ' + entry[0].substring(0, entry[0].length - 1));
            }
            else
            {
                a.push(entry[1] + ' ' + entry[0]);
            }
        }
    }

    return a.length > 1 ? a.slice(0, a.length - 1).join(', ') + ' and ' + a[a.length - 1] : a[0];
}  


console.log(formatDuration(23));