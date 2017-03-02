using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ConApp
{
    class HashTable_Dict
    {
        static int MainHT(string[] args)
        {
            Hashtable htable= GetHashTable();
            Console.WriteLine(htable.ContainsKey("Area"));
            Console.WriteLine(htable.Contains("Area"));

            Console.WriteLine(htable.Contains("MORTGAGE"));
            Console.WriteLine(htable.Contains("Mortgage"));

            int value =(int) htable["Perimeter"];
            Console.WriteLine(value);
            Object value2 = htable["Newkey"];
            Console.WriteLine(value2);

            Console.WriteLine("....");


            Console.ReadKey();

            return 0;

        }

        static public Hashtable GetHashTable()
        {
            Hashtable objHashTable = new Hashtable();
            objHashTable.Add("Area", 1000);
            objHashTable.Add("Perimeter", 55);
            objHashTable.Add("Mortgage", 540);

            return objHashTable;
        }
    }
}
