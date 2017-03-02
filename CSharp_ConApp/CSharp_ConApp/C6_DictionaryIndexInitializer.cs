using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ConApp
{
    //https://www.youtube.com/watch?v=n1dKUF84nfE
    //C# 6 Feature
    class C6_DictionaryIndexInitializer
    {
        static void MainD(string[] args)
        {
            //old way
            Dictionary<string, string> old = new Dictionary<string, string>();
            old.Add("USA", "Washington DC");
            old.Add("India", "New Delhi");

            //new way without Add method
            Dictionary<string, string> capitals = new Dictionary<string, string>()
            {
                ["USA"] = "Washington",
                ["India"] = "New Delhi"
            };

            var numbers = new Dictionary<int, string>
            {
                [7] = "Seven",
                [8] = "Eight"
            };
        }
    }
}
