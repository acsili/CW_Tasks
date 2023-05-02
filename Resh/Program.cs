using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Resh
{
    class Program 
    {
        static void Main(string[] args)
        {
            var c = new ItemCounter<string>(new string[] {"qwrr", "vdvd", "as", "as"});
            Console.WriteLine(c.DistinctItems);
            Console.WriteLine(c.GetCount("x"));
            Console.WriteLine(c.HasItem("as"));

            Console.Read();
        }

    }
}
