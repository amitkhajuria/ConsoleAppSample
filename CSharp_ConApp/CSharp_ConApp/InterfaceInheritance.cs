using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ConApp
{
   
    //http://www.c-sharpcorner.com/UploadFile/rohatash/inherit-multiple-interfaces-with-the-same-method-name-in-C-Sharp/

    interface I1
    {
         void Amit();
    }
    interface I2
    {
        void Amit();
    }
    class ITest : I1 ,I2
    {
         void I1.Amit()
        {
            Console.WriteLine("I am confused in I1");
        }
        void I2.Amit()
        {
            Console.WriteLine("I am confused in I2");
        }
    }
    class InterfaceInheritance 
    {
       
        public static void MainIH()
        {
            //ITest obj = new ITest();
            //obj.Amit();

            I1 obj1 = new ITest();
            obj1.Amit();

            I2 obj2 = new ITest();
            obj2.Amit();

            Console.ReadKey();

            
        }
    }
}
