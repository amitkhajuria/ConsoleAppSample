using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ConApp
{
    class ObjectArray
    {
        static void Main(string[] args)
        {
            object[] array1 = new object[5];
            array1[0] = new object();
            array1[1] = new StringBuilder("Initialized");
            array1[2] = "String literal";
            array1[3] = 3;
            array1[4] = null;

            WriteArray(array1);
            Console.ReadKey();
        }

        static void WriteArray(object[] array)
        {
            foreach (Object element in array)
            {
                if (element != null)
                {
                    Console.WriteLine(element.ToString());
                    Console.WriteLine(element.GetType());
                    Console.WriteLine("---");
                }
            }
        }

    }
}
