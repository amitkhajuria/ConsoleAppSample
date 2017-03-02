using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ConApp
{
    //https://www.youtube.com/watch?v=uGJ5ziO1rLw&t=6s
    class Point1
    {
        public int x = 2;
        public int y = 3;

    }
    class C6_NameofExpression
    {
        public static void MainNE(string[] args)
        {
            Point1 p1 = new Point1();
            
            
            //Console.WriteLine(p);

            //C# 6 Feature
            Console.WriteLine(nameof(p1));
            Console.ReadKey();
        }
    }
}
