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
        public static string YAWIFI(params int[] numbers)
        {
            string yawifi = "";

            IEnumerator numbersEnumerator = numbers.GetEnumerator();
            while (numbersEnumerator.MoveNext()) 
            {
                int number = (int)numbersEnumerator.Current;
                yawifi += (char)number;
            }

            return yawifi;
        }

        static string yawifi = YAWIFI(121, 97, 119, 105, 102, 105);

        static void Main(string[] args)
        {

            Console.WriteLine(yawifi);

            Console.Read();
        }

    }
}
