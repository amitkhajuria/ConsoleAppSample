using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ConApp
{
    class Person
    {
        public string Name;
        public int Age;
      
    }
    //https://www.youtube.com/watch?v=BP46mF_77g8
    //C# 6 Feature
    class C6_StringInterpolation
    {
        static void Main1(string[] args)
        {
            //String interpolation
            Person p = new Person() { Name = "Abcd", Age = 35 };

            //old way
            var s = String.Format("{0} is {1} years's old", p.Name, p.Age);
            Console.WriteLine(s);

            //new way ,//C# 6 Feature
            var s1 = $"{p.Name} is {p.Age} year's old";
            Console.WriteLine(s1);
            Console.ReadKey();


        }
    }
}
