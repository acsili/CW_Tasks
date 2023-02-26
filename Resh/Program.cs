using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Resh
{
    class Program 
    {
        static void Main(string[] args)
        {
            string[] srt = Task_8.dirReduc(new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" });

            foreach (string item in srt)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.ReadKey();  
        }

    }
}
