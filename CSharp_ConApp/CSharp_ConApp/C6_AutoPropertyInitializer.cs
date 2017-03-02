using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ConApp
{
    class AutoProperty
    {
        //old way to set values
        //public person()
        //{
        //    name="Amit";
        //    age=35;
        // }
        public string name { get; set; } =  "Amit" ;
        public int age { get; set; } = 35;

        public DateTime DOB { get; } = DateTime.Now.AddYears(-20);
    }

    class C6_AutoPropertyInitializer
    {
        static void MainA(string[] args)
        {
            AutoProperty p = new AutoProperty();
            Console.WriteLine(p.name + " " + p.age , " "+p.DOB);
            Console.ReadKey();
        }
    }
}
