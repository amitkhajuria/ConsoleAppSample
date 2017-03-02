using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ConApp
{
    class C6_ExpressionBodiedFuntionMember
    {
        static void MainEB(string[] args)
        {
            Point p = new Point(4,5);

        }
    }


    class Point
    {

        public int x, y;

        public Point(int a, int b)
        {
            x = a; y = b;
        }
        //old way
        //public Point Move(int dx,int dy)
        //{
        //    return new Point(x + dx, y + dy);
        //}

        public Point Move(int dx, int dy) => new Point(x + dx, y + dy);



        //public void print()
        //{
        //    Console.WriteLine("FirstName" + "LastName");
        //}
        public void print() => Console.WriteLine("FirstName" + "LastName");



    }
}
   
