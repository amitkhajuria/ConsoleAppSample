using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ConApp
{


    //C# 6 Feature
    class C6_NullConditionalOperator
    {
        static void MainN(string[] args)
        {
            //string s = null;
            string s = "Amit";
            s = Truncate(s,2);
            Console.WriteLine(s);
            Console.ReadKey();
        }
        static string Truncate(string s, int len)
        {
            //old way
            //if (s != null)
            //    return s.Substring(0, len);
            //return null;
            
            //C# 6 Feature
            return s?.Substring(0, len);
        }

    }
}
