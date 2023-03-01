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
        public static bool comp(int[] a, int[] b)
        { 
            int pr = 0;
            if (a != null && b != null)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (Math.Sqrt(b[j]) == a[i])
                        {
                            pr++;
                            
                        }
                    }
                    if (pr == 0) return false;
                    pr = 0;
                }
            }
            else { return false; }
            return true;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(comp(new int[] { 5, 8, 4 }, new int[] { 64, 16, 15 }));


            Console.ReadKey();  
        }

    }
}
