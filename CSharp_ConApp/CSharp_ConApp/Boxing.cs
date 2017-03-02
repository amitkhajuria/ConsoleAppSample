using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharp_ConApp
{
    class Boxing
    {
        /* Sometimes boxing is necessary, but you should avoided it if possible, 
          since it will slow down the performance and increase memory requirements.

         Attempting to unbox a null causes a NullReferenceException.

         Attempting to unbox a reference to an incompatible value type causes an InvalidCastException.
          */

        static void MainBo(string[] args)
        {
            int stackVar = 10;
            //Boxing
            object boxedVar = stackVar;
            //Unboxing
            int unboxed = (int)boxedVar;

            //or

            int i = 10;
            ArrayList arrList = new ArrayList();
            arrList.Add(i);//boxing occur automatically

            int j =(int)arrList[0];

         

        }
    }
}
