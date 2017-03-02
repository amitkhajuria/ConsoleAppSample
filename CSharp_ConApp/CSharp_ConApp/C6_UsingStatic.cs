using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp_ConApp
{
    class C6_UsingStatic
    {
        static void MainU(string[] args)
        {
            //old way
            //Console.WriteLine(Math.Sqrt(3 * 3 + 4 * 4));
            
            //usind Static 
            WriteLine(Math.Sqrt(3 * 3 + 4 * 4));
        }
    }
}
