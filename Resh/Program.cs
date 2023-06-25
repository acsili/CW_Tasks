using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Resh
{
    class Program 
    {
        static void Main(string[] args)
        {
            var l = Task_21.DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);


            foreach (int i in l)
            {
                Console.WriteLine(i);
            }

            Console.Read();
        }

    }
}
