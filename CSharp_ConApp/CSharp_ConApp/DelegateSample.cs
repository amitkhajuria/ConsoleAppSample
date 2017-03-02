using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ConApp
{
    class DelegateSample
    {
        //https://www.youtube.com/watch?v=ifbYA8hyvjc

        public delegate void SomeMethodDelegate();
        public static void MainDel(string[] args)
        {
            //without delegate
            //SomeMethod();

            ////with delegate
            //SomeMethodDelegate obj = new SomeMethodDelegate(SomeMethod);
            ////obj();
            //obj.Invoke();

            //or with deletgate
            //SomeMethodDelegate obj = SomeMethod;
            //obj();

            //
            MyClass obj1 = new MyClass();
            obj1.longRunning(callback);

        }
        static void callback(int i)
        {
            Console.WriteLine(i);
        }
        static void SomeMethod()
        {
            Console.WriteLine("Method called");
            Console.ReadKey();
        }
    }

    class MyClass
    {
        public delegate void callback(int i);
        public void longRunning(callback obj)
        {
            for (int i = 0; i <= 1000; i++)
            {
                obj(i);
            }
        }
    }


}
