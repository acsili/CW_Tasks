function nbYear(p0, percent, aug, p) 
{
    let ys = 0;
    percent = percent / 100;
    while (p0 < p)
    {
        p0 = p0 + p0 * percent + aug;
        ys++;
    }
    return ys;
}


console.log(nbYear(1500, 5, 100, 5000))