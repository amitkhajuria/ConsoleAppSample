using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_ConApp
{
    class SingletonCDP
    {
        private SingletonCDP() //make the constructor private so that this class cannot be  //instantiated 
        { }

        private static SingletonCDP singletonObj = new SingletonCDP();
        public static SingletonCDP GetInstance()
        {
            return  singletonObj;
        }

        public void ShowMessage()
        {
            Console.WriteLine("show message");
        }
    }

    class Client
    {
        public static void Main1(string[] args)
        {
            //SingletonCDP obj = new SingletonCDP();  // Not accessable due to its protection level

            //get the only Object Available
            SingletonCDP obj = SingletonCDP.GetInstance();
            obj.ShowMessage();
            Console.ReadKey();



        }
    }
}
